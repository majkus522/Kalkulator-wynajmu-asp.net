using Common;
using Domain;

namespace Infrastructure
{
	public interface ICalculator
	{
		public Task<Result> GetCars();
		public Task<Result> Get(int id, InputData Data);
		public Task PostCar(CarRequest car);
	}
}