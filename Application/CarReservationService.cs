using Common;
using DataAcces;

namespace Application
{
	public class CarReservationService : ICarReservationService
	{
		private readonly ICarRepository repository;

		public CarReservationService(ICarRepository repository)
		{
			this.repository = repository;
		}

		public void AddReservation(InputData Data)
		{

		}
	}
}