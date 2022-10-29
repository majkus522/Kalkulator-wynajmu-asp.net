using Domain;

namespace Application
{
	public interface IReservationAPI
	{
		public Task<ICollection<Car>> GetAvailableCars(DateTime start, DateTime end);
	}
}