using Common;
using Domain;

namespace Application
{
	public interface ICalculator
	{
		public Task<ICollection<Car>> GetCars();
		public Task<Result> Get(int id, InputData Data);
		public Task<int> AddCar(AddCarRequest car);
	}
}