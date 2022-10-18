using Domain;
using DataAcces;

namespace Application
{
	public class CarRepository : ICarRepository
	{
		private readonly DatabaseContext _context;

		public CarRepository(DatabaseContext context)
		{
			_context = context;
		}

		public void Add(Car car)
		{
			_context.Cars.Add(car);
		}

		public void Delete(Car car)
		{
			_context.Cars.Remove(car);
		}

		public Car Get(int id)
		{
			return _context.Cars.SingleOrDefault(c => c.Id == id);
		}

		public List<Car> GetAll()
		{
			return _context.Cars.ToList();
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}