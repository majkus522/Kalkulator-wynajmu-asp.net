using Application.Cars.Requests;
using Common;
using Domain;
using Domain.Cars;

namespace Application.Repositories
{
	public interface ICalculator
	{
		public Task<ICollection<Car>> GetCars();
		public Task<Result> Get(Car car, InputData Data);
		public Task<int> AddCar(AddCarRequest car);
	}
}