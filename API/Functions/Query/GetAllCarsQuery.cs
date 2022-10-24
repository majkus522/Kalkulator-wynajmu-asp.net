using Application;
using Domain;
using MediatR;

namespace API.Functions.Query
{
	public record GetAllCarsQuery : IRequest<ICollection<Car>>;
}