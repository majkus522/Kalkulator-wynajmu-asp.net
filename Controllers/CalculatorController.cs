using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace KalkulatorWynajmu.Controllers
{
	public enum CarClass
	{
		Basic, Standard, Medium, Premium
	}

	[Route("api/kalkulator")]
	[ApiController]
	public class KalkulatorWynajmu : ControllerBase
	{
		private readonly ILogger<KalkulatorWynajmu> _logger;

		public KalkulatorWynajmu(ILogger<KalkulatorWynajmu> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public ActionResult<string> Get([FromQuery]int distance, [FromQuery] int year, [FromQuery] DateTime start, [FromQuery] DateTime end, [FromQuery] CarClass carClass)
		{
			DateTime today = DateTime.Today;
			if (today > start)
			{
				return Ok("Niepoprawna data rozpoczęcia wynajmu");
			}
			if(today > end || end < start)
			{
				return Ok("Niepoprawna data zakończenia wynajmu");
			}
			if(distance < 0)
			{
				return Ok("Niepoprawna odległość");
			}
			if (year < 1900)
			{
				return Ok("Niepoprawny rok wydania prawa jazdy");
			}

			float fuelPrice = 6.96f;
			float basePrice = 40;
			float fuelConsumption = 7.5f;
			int modelAvaliable = 1;

			if(today.Year - year < 3 && carClass == CarClass.Premium)
				return Ok("Nie możesz wyporzyczyć tego pojazdu");

			int days = end.Subtract(start).Days;
			float daysCost = basePrice * days;
			string placeholder = "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "):\t\t" + daysCost + " zł\r\n";
			float finalResult = daysCost;

			float carClassCost = 0;
			switch(carClass)
			{
				case CarClass.Standard:
					carClassCost = .3f * daysCost;
					break;

				case CarClass.Medium:
					carClassCost = .6f * daysCost;
					break;

				case CarClass.Premium:
					carClassCost = daysCost;
					break;
			}
			finalResult += carClassCost;
			placeholder += "Cena klasy pojazdu:\t\t\t" + carClassCost + " zł\r\n";

			if (today.Year - year < 5)
			{
				float expirienceCost = .2f * finalResult;
				placeholder += "Niedoświadczony kierowca:\t" + expirienceCost + " zł\r\n";
				finalResult += expirienceCost;
			}

			if (modelAvaliable < 3)
			{
				float modelCountCost = .15f * finalResult;
				placeholder += "Mała ilośc pojazdów:\t\t" + modelCountCost + " zł\r\n";
				finalResult += modelCountCost;
			}

			float fuelCost = distance / 100 * fuelConsumption * fuelPrice;
			placeholder += "Cena paliwa:\t\t\t\t" + fuelCost + " zł\r\n";
			finalResult += fuelCost;

			placeholder += "---------------------------------------\r\n";
			placeholder += "Razem:\t\t\t\t\t\t" + finalResult + " zł";

			return Ok(placeholder);
		}
	}
}