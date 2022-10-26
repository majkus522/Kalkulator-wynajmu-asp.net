using Application;
using Domain;
using MediatR;
using Org.BouncyCastle.Asn1.Crmf;

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
			var car = new Car(carRequest.Brand, carRequest.Model, carRequest.CarAvaliable, carRequest.BasePrice, carRequest.FuelConsumption, carRequest.CarClass);
			return await _carRepository.Add(car);

		}
	}
}
