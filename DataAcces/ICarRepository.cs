using Domain;

namespace DataAcces
{
	public interface ICarRepository
	{
		public void add(Car car);

		public Car get(int id);

		public List<Car> getAll();

		public void delete(Car car);

		public void SaveChanges();
	}
}