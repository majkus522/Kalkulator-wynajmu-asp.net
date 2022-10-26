using Application;
using MediatR;

namespace API.Functions.Command
{
	public class PutReservationCommandHandler : IRequestHandler<PutReservationCommand, bool>
	{
		ICarReservationService _service;

		public PutReservationCommandHandler(ICarReservationService service)
		{
			_service = service;
		}

		public async Task<bool> Handle(PutReservationCommand request, CancellationToken cancellationToken)
		{
			return await _service.AddReservation(request.distance, request.year, request.start, request.end, request.carId);
        }
	}
}