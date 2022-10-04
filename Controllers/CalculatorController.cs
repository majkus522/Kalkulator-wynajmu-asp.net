using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace KalkulatorWynajmu.Controllers
{
	public enum CarClass
	{
		Basic = 10, Standard = 13, Medium = 16, Premium = 20
	}

	[Route("api/kalkulator")]
	[ApiController]
	public class KalkulatorWynajmu : ControllerBase
	{
		public KalkulatorWynajmu(ILogger<KalkulatorWynajmu> logger) { }

		[HttpGet]
		public ActionResult<string> Get([FromQuery] int distance, [FromQuery] int year, [FromQuery] DateTime start, [FromQuery] DateTime end, [FromQuery] CarClass carClass)
		{
			var today = DateTime.Today;
			if (today > start)
			{
				return BadRequest("Niepoprawna data rozpoczęcia wynajmu");
			}
			if (today > end || end < start)
			{
				return BadRequest("Niepoprawna data zakończenia wynajmu");
			}
			if (distance < 0)
			{
				return BadRequest("Niepoprawna odległość");
			}
			if (year < 1900)
			{
				return BadRequest("Niepoprawny rok wydania prawa jazdy");
			}

			var fuelPrice = 6.96f;
			var basePrice = 40.0f;
			var fuelConsumption = 7.5f;
			var modelAvaliable = 1;

			if (today.Year - year < 3 && carClass == CarClass.Premium)
				return BadRequest("Nie możesz wyporzyczyć tego pojazdu");

			var days = end.Subtract(start).Days;
			var daysCost = basePrice * days;
			string placeholder = "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "):\t\t" + daysCost + " zł\r\n";
			var finalResult = daysCost;

			var carClassCost = daysCost * ((int)carClass) / 10;
			finalResult += carClassCost;
			placeholder += "Cena klasy pojazdu:\t\t\t" + carClassCost + " zł\r\n";

			if (today.Year - year < 5)
			{
				var expirienceCost = .2f * finalResult;
				placeholder += "Niedoświadczony kierowca:\t" + expirienceCost + " zł\r\n";
				finalResult += expirienceCost;
			}

			if (modelAvaliable < 3)
			{
				var modelCountCost = .15f * finalResult;
				placeholder += "Mała ilośc pojazdów:\t\t" + modelCountCost + " zł\r\n";
				finalResult += modelCountCost;
			}

			var fuelCost = distance / 100 * fuelConsumption * fuelPrice;
			placeholder += "Cena paliwa:\t\t\t\t" + fuelCost + " zł\r\n";
			finalResult += fuelCost;

			placeholder += "---------------------------------------\r\n";
			placeholder += "Razem:\t\t\t\t\t\t" + finalResult + " zł";

			return Ok(placeholder);
		}
	}
}