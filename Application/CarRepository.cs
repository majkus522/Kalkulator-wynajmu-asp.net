using Domain;
using DataAcces;
using Microsoft.EntityFrameworkCore;

namespace Application
{
	public class CarRepository : ICarRepository
	{
		private readonly DatabaseContext _context;

		public CarRepository(DatabaseContext context)
		{
			_context = context;
		}

		public async void Add(Car car)
		{
			_context.Cars.Add(car);
		}

		public async void Delete(Car car)
		{
			_context.Cars.Remove(car);
		}

		public async Task<Car> Get(int id)
		{
			return await _context.Cars.SingleOrDefaultAsync(c => c.Id == id);
		}

		public async Task<ICollection<Car>> GetAll()
		{
			return await _context.Cars.ToListAsync();
		}

		public async void SaveChanges()
		{
			await _context.SaveChangesAsync();
		}
	}
}