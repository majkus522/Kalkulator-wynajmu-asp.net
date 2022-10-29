using Application;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAcces
{
	public class CarReservationService : ICarReservationService
	{
		private readonly ICarRepository _repository;
		private readonly DatabaseContext _context;

		public CarReservationService(ICarRepository repository, DatabaseContext context)
		{
			_repository = repository;
			_context = context;
		}

		public async Task<bool> AddReservation(int distance, int year, DateTime start, DateTime end, int carId)
		{
			if(!await CheckReservation(distance, year, start, end, carId))
			{
				return false;
			}
			var reservation = new CarReservation(carId, start, end, distance, year);
			_context.Reservations.Add(reservation);
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<bool> CheckReservation(int distance, int year, DateTime start, DateTime end, int carId)
		{
			var car = await _repository.Get(carId);
			if (car == null)
				return false;
			int carsAvaliable = await _repository.GetCount(car.Brand, car.Model);
			var carsTaken = await _context.Reservations.CountAsync(c => c.CarId == carId && ((c.Start > start && c.Start < end) || (c.End > start && c.End < end)));
			return carsAvaliable > carsTaken;
		}

		public async Task<ICollection<Car>> GetAvaliableCars(DateTime start, DateTime end)
		{
			var reservations = await _context.Reservations.Where(c => c.End < start && c.Start > end).ToListAsync();
			var taken = new List<int>();
			foreach(var reservation in reservations)
				taken.Add(reservation.Id);
			return await _context.Cars.Where(c => !taken.Contains(c.Id)).ToListAsync();
		}
	}
}