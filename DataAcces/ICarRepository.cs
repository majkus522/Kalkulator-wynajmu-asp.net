using Domain;

namespace DataAcces
{
	public interface ICarRepository
	{
		public Task Add(Car car);
		public Task Delete(Car car);
		public Task<Car> Get(int id);
		public Task<ICollection<Car>> GetAll();
		public Task Put(Car car);
		public Task SaveChanges();
	}
}