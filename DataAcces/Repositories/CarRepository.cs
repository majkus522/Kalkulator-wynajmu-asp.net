using Application;
using Application.Repositories;
using DataAcces.EF;
using Domain;
using Domain.Cars;
using Microsoft.EntityFrameworkCore;

namespace DataAcces.Repositories
{
	public class CarRepository : ICarRepository
	{
		private readonly DatabaseContext _context;

		public CarRepository(DatabaseContext context)
		{
			_context = context;
		}

		public async Task<int> Add(Car car)
		{
			_context.Cars.Add(car);
			_context.SaveChanges();
			return car.Id;
		}

		public async Task Delete(Car car)
		{
			_context.Cars.Remove(car);
			_context.SaveChanges();
		}

		public async Task<Car?> Get(int id)
		{
			return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<ICollection<Car>> GetAll()
		{
			return await _context.Cars.ToListAsync();
		}
	}
}