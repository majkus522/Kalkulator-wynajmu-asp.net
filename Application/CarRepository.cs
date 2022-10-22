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

		public async Task Add(Car car)
		{
			_context.Cars.Add(car);
		}

		public async Task Delete(Car car)
		{
			_context.Cars.Remove(car);
		}

		public async Task<Car> Get(int id)
		{
			return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<ICollection<Car>> GetAll()
		{
			return await _context.Cars.ToListAsync();
		}

		public async Task Put(Car car)
		{
            _context.Entry(car).State = EntityState.Modified;
        }

		public async Task SaveChanges()
		{
			await _context.SaveChangesAsync();
		}
	}
}