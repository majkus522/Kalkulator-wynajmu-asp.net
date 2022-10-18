using Domain;

namespace DataAcces
{
	public interface ICarRepository
	{
		public void Add(Car car);
		public void Delete(Car car);
		public Car Get(int id);
		public ICollection<Car> GetAll();
		public void SaveChanges();
	}
}