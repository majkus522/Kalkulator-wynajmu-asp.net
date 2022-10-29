using Application;
using DataAcces;
using Domain;

namespace API
{
	public class ReservationAPI : IReservationAPI
	{
		private readonly DatabaseContext _context;

		public ReservationAPI(DatabaseContext context)
		{
			_context = context;
		}

		public async Task<ICollection<Car>> GetAvailableCars(DateTime start, DateTime end)
		{
			return new List<Car>();
		}
	}
}