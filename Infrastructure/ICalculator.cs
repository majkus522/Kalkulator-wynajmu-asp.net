using Common;
using Domain;

namespace Infrastructure
{
	public interface ICalculator
	{
		public Task<Result> getCars();
		public Task<Result> get(int id, InputData Data);
		public Task<Result> put(int id, Car car);
		public Task postCar(Car car);
	}
}