using Domain.Cars.ValueObjects.Categories;
using Domain.Cars.ValueObjects.Models;

namespace Domain.Cars
{
	public class Car
	{
		public int Id { get; set; }
		public float BasePrice { get; set; }
		public float FuelConsumption { get; set; }
		public CarClassE CarClass { get; set; }
		public Model Model { get; set; }

		public Car(float basePrice, float fuelConsumption, CarClassE carClass, Model model)
		{
			BasePrice = basePrice;
			FuelConsumption = fuelConsumption;
			CarClass = carClass;
			Model = model;
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