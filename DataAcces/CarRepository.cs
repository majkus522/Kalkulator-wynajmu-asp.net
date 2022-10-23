using Domain;
using Application;
using Microsoft.EntityFrameworkCore;

namespace DataAcces
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
			await SaveChanges();
			return car.Id;
		}

		public async Task Delete(Car car)
		{
			_context.Cars.Remove(car);
			await SaveChanges();
		}

		public async Task<Car?> Get(int id)
		{
			return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<ICollection<Car>> GetAll()
		{
			return await _context.Cars.ToListAsync();
		}

		public async Task SaveChanges()
		{
			await _context.SaveChangesAsync();
		}
	}
}