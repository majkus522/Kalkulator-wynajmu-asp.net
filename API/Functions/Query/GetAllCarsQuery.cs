using Application;
using Domain;
using MediatR;

namespace API.Functions.Query
{
	public class GetAllCarsQuery : IRequest<ICollection<Car>>
	{
		public ICalculator calculator { get; set; }
	}
}