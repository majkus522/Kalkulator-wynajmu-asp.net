using Application;

namespace DataAcces
{
	public class CarReservationService : ICarReservationService
	{
		private readonly ICarRepository repository;

		public CarReservationService(ICarRepository repository)
		{
			this.repository = repository;
		}

		public async void AddReservation(int distance, int year, DateTime start, DateTime end)
		{

		}
	}
}