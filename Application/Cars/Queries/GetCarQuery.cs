using Domain;
using Domain.Cars;
using MediatR;

namespace Application.Cars.Queries
{
	public record GetCarQuery(int Id) : IRequest<Car>;
}