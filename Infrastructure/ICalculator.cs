using Common;
using DataAcces;
using Domain;
using System.Threading.Tasks;

namespace Infrastructure
{
	public interface ICalculator
	{
		public Task<Result> getCars(DatabaseContext context);
		public Task<Result> get(int id, InputData Data, DatabaseContext context);
		public Task<Result> put(int id, Car car, DatabaseContext context);
		public Task postCar(Car car, DatabaseContext context);
	}
}