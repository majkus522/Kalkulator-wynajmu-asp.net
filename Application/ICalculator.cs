using Common;

namespace Application
{
	public interface ICalculator
	{
		public Task<Result> GetCars();
		public Task<Result> Get(int id, InputData Data);
		public Task<int> AddCar(AddCarRequest car);
	}
}