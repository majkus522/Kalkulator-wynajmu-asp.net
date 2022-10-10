using Common;

namespace Domain
{
	public class Car
	{
		public int Id { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public int CarAvaliable { get; set; }
		public float BasePrice { get; set; }
		public float FuelConsumption { get; set; }
		public ECarClass CarClass { get; set; }
	}
}