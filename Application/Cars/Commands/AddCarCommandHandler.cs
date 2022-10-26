using Application.Repositories;
using Domain;
using Domain.Cars;
using MediatR;

namespace Application.Cars.Commands
{
	public class AddCarCommandHandler : IRequestHandler<AddCarCommand, int>
	{
		ICarRepository _carRepository;

		public AddCarCommandHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<int> Handle(AddCarCommand request, CancellationToken cancellationToken)
		{
			var carRequest = request.Request;
			var car = new Car(carRequest.Brand, carRequest.Model, carRequest.CarAvaliable, carRequest.BasePrice, carRequest.FuelConsumption, carRequest.CarClass);
			return await _carRepository.Add(car);

		}
	}
}
