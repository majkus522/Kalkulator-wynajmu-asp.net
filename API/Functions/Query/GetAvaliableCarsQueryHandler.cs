using Application;
using Domain;
using MediatR;

namespace API.Functions.Query
{
	public class GetAvaliableCarsQueryHandler : IRequestHandler<GetAvaliableCarsQuery, ICollection<Car>>
	{
		ICarReservationService _service;

		public GetAvaliableCarsQueryHandler(ICarReservationService service)
		{
			_service = service;
		}

		public async Task<ICollection<Car>> Handle(GetAvaliableCarsQuery request, CancellationToken cancellationToken)
		{
			return await _service.GetAvaliableCars(request.start, request.end);
		}
	}
}