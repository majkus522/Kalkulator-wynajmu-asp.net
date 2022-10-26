using MediatR;

namespace Application.Reservations.Commands
{
	public record PutReservationCommand(int CarId, int Distance, int Year, DateTime Start, DateTime End) : IRequest<bool>;
}