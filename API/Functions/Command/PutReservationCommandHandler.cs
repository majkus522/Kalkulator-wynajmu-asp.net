using Application;
using DataAcces.Migrations;
using MediatR;

namespace API.Functions.Command
{
	public class PutReservationCommandHandler : IRequestHandler<PutReservationCommand, Unit>
	{
		ICarReservationService _service;

		public PutReservationCommandHandler(ICarReservationService service)
		{
			_service = service;
		}

		public async Task<Unit> Handle(PutReservationCommand request, CancellationToken cancellationToken)
		{
			await _service.AddReservation(request.distance, request.year, request.start, request.end, request.carId);
			return Unit.Value;
		}
	}
}