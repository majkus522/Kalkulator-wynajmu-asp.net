namespace Application
{
	public interface ICarReservationService
	{
		public Task AddReservation(int distance, int year, DateTime start, DateTime end, int carId);
		public Task<bool> CheckReservation(int distance, int year, DateTime start, DateTime end, int carId);
	}
}