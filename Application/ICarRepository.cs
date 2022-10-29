using Domain;

namespace Application
{
	public interface ICarRepository
	{
		public Task<int> Add(Car car);
		public Task Delete(Car car);
		public Task<Car?> Get(int id);
		public Task<ICollection<Car>> GetAll();
		public Task<int> GetCount(string brand, string model);
	}
}