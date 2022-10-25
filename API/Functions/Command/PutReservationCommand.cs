using MediatR;

namespace API.Functions.Command
{
	public record PutReservationCommand(int carId, int distance, int year, DateTime start, DateTime end) : IRequest<Unit>;
}