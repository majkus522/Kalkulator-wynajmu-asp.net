using Application;
using Domain;
using MediatR;

namespace API.Functions.Command
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
			var carRequest = request.request;
			var car = new Car()
			{
				Brand = carRequest.Brand,
				Model = carRequest.Model,
				BasePrice = carRequest.BasePrice,
				FuelConsumption = carRequest.FuelConsumption,
				CarClass = carRequest.CarClass,
				ProductionDate = carRequest.ProductionDate,
				RegistrationNumber = carRequest.RegistrationNumber,
				CarState = carRequest.CarState
			};
			return await _carRepository.Add(car);
		}
	}
}