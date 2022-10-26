using Application.Cars.Requests;
using Common;
using MediatR;

namespace Application.Cars.Commands
{
	public record AddCarCommand(AddCarRequest Request) : IRequest<int>;
}