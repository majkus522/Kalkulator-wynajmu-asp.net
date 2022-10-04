using KalkulatorWynajmu.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalkulatorWynajmu.Entities
{
	public class Car
	{
		public int Id { get; set; }
		public string brand { get; set; }
		public string model { get; set; }
		public int carAvaliable { get; set; }
		public float basePrice { get; set; }
		public float fuelConsumption { get; set; }
		public CarClass carClass { get; set; }
	}
}
