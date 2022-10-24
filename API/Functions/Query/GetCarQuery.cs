using Domain;
using MediatR;

namespace API.Functions.Query
{
	public record GetCarQuery(int id) : IRequest<Car>;
}