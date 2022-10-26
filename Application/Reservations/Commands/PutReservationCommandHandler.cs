using Application.Repositories;
using MediatR;

namespace Application.Reservations.Commands
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
			return await _service.AddReservation(request.Distance, request.Year, request.Start, request.End, request.CarId);
        }
	}
}