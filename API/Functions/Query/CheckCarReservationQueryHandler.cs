using API.Functions.Command;
using Application;
using MediatR;

namespace API.Functions.Query
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
			return await _service.CheckReservation(request.distance, request.year, request.start, request.end, request.carId);
		}
	}
}
