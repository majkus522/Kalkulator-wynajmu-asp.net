using Common;
using DataAcces;
using Domain;

namespace Application
{
	public class CarReservationService : ICarReservationService
	{
		ICarRepository repository;

		public CarReservationService(ICarRepository repository)
		{
			this.repository = repository;
		}

		public void addReservation(InputData Data, Car car)
		{

		}
	}
}