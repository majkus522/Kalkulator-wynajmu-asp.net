using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
		[HttpGet]
		public ActionResult<string> Get([FromQuery] InputData data)
		{
			var today = DateTime.Today;
			var carClass = CarClass.Basic;
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
			var basePrice = 40.0f;
			var fuelConsumption = 7.5f;
			var modelAvaliable = 1;

			if (today.Year - data.Year < 3 && carClass == CarClass.Premium)
				return BadRequest("Nie możesz wyporzyczyć tego pojazdu");

			var days = data.End.Subtract(data.Start).Days;
			var daysCost = basePrice * days;
			string placeholder = "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "): " + daysCost + " zł\r\n";
			var finalResult = daysCost;

			var carClassCost = daysCost * ((int)carClass) / 10;
			finalResult += carClassCost;
			placeholder += "Cena klasy pojazdu: " + carClassCost + " zł\r\n";

			if (today.Year - data.Year < 5)
			{
				var expirienceCost = .2f * finalResult;
				placeholder += "Niedoświadczony kierowca: " + expirienceCost + " zł\r\n";
				finalResult += expirienceCost;
			}

			if (modelAvaliable < 3)
			{
				var modelCountCost = .15f * finalResult;
				placeholder += "Mała ilośc pojazdów: " + modelCountCost + " zł\r\n";
				finalResult += modelCountCost;
			}

			var fuelCost = data.Distance / 100 * fuelConsumption * fuelPrice;
			placeholder += "Cena paliwa: " + fuelCost + " zł\r\n";
			finalResult += fuelCost;

			placeholder += "---------------------------------------\r\n";
			placeholder += "Razem: " + finalResult + " zł";

			return Ok(placeholder);
		}
	}
}