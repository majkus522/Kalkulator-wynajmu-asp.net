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

		public async Task AddReservation(int distance, int year, DateTime start, DateTime end, int carId)
		{
			var reservation = new CarReservation(carId, start, end, distance, year);
			_context.Reservations.Add(reservation);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> CheckReservation(int distance, int year, DateTime start, DateTime end, int carId)
		{
			int carsAvaliable = (await _repository.Get(carId)).CarAvaliable;
			var taken = _context.Reservations.Where(c => c.CarId == carId && (c.Start > start || c.Start < end || c.End > start || c.End < end));
			int carsTaken = (await taken.ToArrayAsync()).Length;
			return carsAvaliable > carsTaken;
		}
	}
}