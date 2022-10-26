using Application.Repositories;
using Application.Reservations.Queries;
using MediatR;

namespace DataAcces.Handlers.Reservations.Queries
{
	public class CheckCarReservationQueryHandler : IRequestHandler<CheckCarReservationQuery, bool>
	{
		ICarReservationService _service;

		public CheckCarReservationQueryHandler(ICarReservationService service)
		{
			_service = service;
		}

		public async Task<bool> Handle(CheckCarReservationQuery request, CancellationToken cancellationToken)
		{
			return await _service.CheckReservation(request.Distance, request.Year, request.Start, request.End, request.CarId);
		}
	}
}