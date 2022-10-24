using Application;
using Domain;
using MediatR;

namespace API.Functions.Query
{
	public class GetAllCrasQueryHandler : IRequestHandler<GetAllCarsQuery, ICollection<Car>>
	{
		public async Task<ICollection<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
		{
			return await request.calculator.GetCars();
			/*return new List<Car>()
			{
				new Car()
				{
					Id = 1, BasePrice = 1, Brand = "majkus522", CarAvaliable = 1, CarClass = Common.CarClassE.Basic, FuelConsumption = 1, Model = "majkus522"
				}
			};*/
		}
	}
}