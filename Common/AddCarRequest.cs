namespace Common
{
	public class AddCarRequest
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int CarAvaliable { get; set; }
		public float BasePrice { get; set; }
		public float FuelConsumption { get; set; }
		public CarClassE CarClass { get; set; }
	}
}