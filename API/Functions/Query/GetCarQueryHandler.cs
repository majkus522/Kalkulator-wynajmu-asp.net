using Application;
using Domain;
using MediatR;

namespace API.Functions.Query
{
	public class GetCarQueryHandler : IRequestHandler<GetCarQuery, Car>
	{
		ICarRepository _carRepository;

		public GetCarQueryHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}
		public async Task<Car> Handle(GetCarQuery request, CancellationToken cancellationToken)
		{
			return await _carRepository.Get(request.id);
		}
	}
}