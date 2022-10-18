using Common;
using Domain;

namespace DataAcces
{
	public interface ICarReservationService
	{
		public void addReservation(InputData Data, Car car);
	}
}