using Common;
using MediatR;

namespace API.Functions.Command
{
	public record AddCarCommand(AddCarRequest request) : IRequest<int>;
}