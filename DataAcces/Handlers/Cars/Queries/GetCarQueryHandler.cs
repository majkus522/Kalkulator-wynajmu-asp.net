using Application.Cars.Queries;
using Application.Repositories;
using Domain;
using Domain.Cars;
using MediatR;

namespace DataAcces.Handlers.Cars.Queries
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
			return await _carRepository.Get(request.Id);
		}
	}
}