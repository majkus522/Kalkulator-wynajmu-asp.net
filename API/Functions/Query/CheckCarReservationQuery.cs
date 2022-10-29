using MediatR;

namespace API.Functions.Query
{
	public record CheckCarReservationQuery(int carId, int distance, int year, DateTime start, DateTime end) : IRequest<bool>;
}