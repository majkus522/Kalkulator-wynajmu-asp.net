using Domain;
using DataAcces;

namespace Application
{
	public class CarRepository : ICarRepository
	{
		DatabaseContext context;

		public CarRepository(DatabaseContext context)
		{
			this.context = context;
		}

		public void add(Car car)
		{
			context.Cars.Add(car);
		}

		public void delete(Car car)
		{
			context.Cars.Remove(car);
		}

		public Car get(int id)
		{
			return context.Cars.Find(id);
		}

		public List<Car> getAll()
		{
			return context.Cars.ToList();
		}

		public void SaveChanges()
		{
			context.SaveChanges();
		}
	}
}