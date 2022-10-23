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
		public CarClassE CarClass { get; set; }

		public Car(int id, string brand, string model, int carAvaliable, float basePrice, float fuelConsumption, CarClassE carClass)
		{
			Id = id;
			Brand = brand;
			Model = model;
			CarAvaliable = carAvaliable;
			BasePrice = basePrice;
			FuelConsumption = fuelConsumption;
			CarClass = carClass;
		}

		public Car() { }
	}
}