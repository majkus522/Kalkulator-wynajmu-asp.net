using MediatR;

namespace Application.Reservations.Queries
{
	public record CheckCarReservationQuery(int CarId, int Distance, int Year, DateTime Start, DateTime End) : IRequest<bool>;
}