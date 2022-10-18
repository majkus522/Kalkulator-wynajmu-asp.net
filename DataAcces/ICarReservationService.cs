using Common;

namespace DataAcces
{
	public interface ICarReservationService
	{
        public void AddReservation(int distance, int year, DateTime start, DateTime end);
	}
}