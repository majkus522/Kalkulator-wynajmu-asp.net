using Common;

namespace Domain
{
	public class Car
	{
		public int Id { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public float BasePrice { get; set; }
		public float FuelConsumption { get; set; }
		public CarClassE CarClass { get; set; }
		public DateTime ProductionDate { get; set; }
		public string RegistrationNumber { get; set; }
		public CarStateE CarState { get; set; }
	}
}