using Application.Cars.Queries;
using Application.Repositories;
using Domain;
using Domain.Cars;
using MediatR;

namespace DataAcces.Handlers.Cars.Queries
{
	public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, ICollection<Car>>
	{
		ICarRepository _carRepository;

		public GetAllCarsQueryHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<ICollection<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
		{
			return await _carRepository.GetAll();
		}
	}
}