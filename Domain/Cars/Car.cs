namespace Domain.Cars
{
	public class Car
	{
		public int Id { get; set; }
		public string Brand { get; set; } = null!;
		public string Model { get; set; } = null!;
		public int CarAvaliable { get; set; }
		public float BasePrice { get; set; }
		public float FuelConsumption { get; set; }
		public CarClassE CarClass { get; set; }

		public Car(string brand, string model, int carAvaliable, float basePrice, float fuelConsumption, CarClassE carClass)
		{
			Brand = brand;
			Model = model;
			CarAvaliable = carAvaliable;
			BasePrice = basePrice;
			FuelConsumption = fuelConsumption;
			CarClass = carClass;
		}

		public Car() { }
	}
	
	public enum CarClassE
	{
		Basic = 10, Standard = 20, Medium = 30, Premium = 40
	}
	
	public static class ExtensionMethods
	{
		public static float GetValue(this CarClassE carClass) =>
			carClass switch
			{
				CarClassE.Basic => 1f,
				CarClassE.Standard => 1.3f,
				CarClassE.Medium => 1.6f,
				CarClassE.Premium => 2f,
				_ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(carClass)),
			};
	}
	
	
}