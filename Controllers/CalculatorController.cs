using KalkulatorWynajmu.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

public enum CarClass
{
	Basic = 10, Standard = 13, Medium = 16, Premium = 20
}

namespace KalkulatorWynajmu.Controllers
{
    [Route("api/kalkulator")]
	[ApiController]
	public class KalkulatorWynajmu : ControllerBase
	{
		private readonly DatabaseContext _context;

		public KalkulatorWynajmu(DatabaseContext context)
		{
			_context = context;
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<IEnumerable<Car>>> Get(int id, [FromQuery] InputData data)
		{
			var placeholder = "";
			var car = await _context.cars.FindAsync(id);
			if (car == null)
				return NotFound();
			placeholder += car.brand + " " + car.model + "\r\n\r\n";
			var today = DateTime.Today;
			if (today > data.Start)
			{
				return BadRequest("Niepoprawna data rozpoczęcia wynajmu");
			}
			if (today > data.End || data.End < data.Start)
			{
				return BadRequest("Niepoprawna data zakończenia wynajmu");
			}
			if (data.Distance < 0)
			{
				return BadRequest("Niepoprawna odległość");
			}
			if (data.Year < 1900)
			{
				return BadRequest("Niepoprawny rok wydania prawa jazdy");
			}

			var fuelPrice = 6.96f;

			if (today.Year - data.Year < 3 && car.carClass == CarClass.Premium)
				return BadRequest("Nie możesz wyporzyczyć tego pojazdu");

			var days = data.End.Subtract(data.Start).Days;
			var daysCost = car.basePrice * days;
			placeholder += "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "): " + Math.Round(daysCost, 2) + " zł\r\n";
			var finalResult = daysCost;

			var carClassCost = daysCost * ((int)car.carClass) / 10;
			finalResult += carClassCost;
			placeholder += "Cena klasy pojazdu: " + Math.Round(carClassCost, 2) + " zł\r\n";

			if (today.Year - data.Year < 5)
			{
				var expirienceCost = .2f * finalResult;
				placeholder += "Niedoświadczony kierowca: " + Math.Round(expirienceCost, 2) + " zł\r\n";
				finalResult += expirienceCost;
			}

			if (car.carAvaliable < 3)
			{
				var modelCountCost = .15f * finalResult;
				placeholder += "Mała ilośc pojazdów: " + Math.Round(modelCountCost, 2) + " zł\r\n";
				finalResult += modelCountCost;
			}

			var fuelCost = data.Distance / 100 * car.fuelConsumption * fuelPrice;
			placeholder += "Cena paliwa: " + Math.Round(fuelCost, 2) + " zł\r\n";
			finalResult += fuelCost;

			placeholder += "---------------------------------------\r\n";
			placeholder += "Razem: " + Math.Round(finalResult, 2) + " zł";

			return Ok(placeholder);
		}
	}
}