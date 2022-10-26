using Domain;
using Domain.Cars;
using MediatR;

namespace Application.Cars.Queries
{
	public record GetAllCarsQuery : IRequest<ICollection<Car>>;
}