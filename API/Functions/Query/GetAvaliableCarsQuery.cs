using Domain;
using MediatR;

namespace API.Functions.Query
{
	public record GetAvaliableCarsQuery(DateTime start, DateTime end) : IRequest<ICollection<Car>>;
}