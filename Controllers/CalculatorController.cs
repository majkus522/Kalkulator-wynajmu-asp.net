﻿using Microsoft.AspNetCore.Mvc;
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
			CarClass carClass = CarClass.Basic;
			if (today > data.start)
			{
				return BadRequest("Niepoprawna data rozpoczęcia wynajmu");
			}
			if (today > data.end || data.end < data.start)
			{
				return BadRequest("Niepoprawna data zakończenia wynajmu");
			}
			if (data.distance < 0)
			{
				return BadRequest("Niepoprawna odległość");
			}
			if (data.year < 1900)
			{
				return BadRequest("Niepoprawny rok wydania prawa jazdy");
			}

			var fuelPrice = 6.96f;
			var basePrice = 40.0f;
			var fuelConsumption = 7.5f;
			var modelAvaliable = 1;

			if (today.Year - data.year < 3 && carClass == CarClass.Premium)
				return BadRequest("Nie możesz wyporzyczyć tego pojazdu");

			var days = data.end.Subtract(data.start).Days;
			var daysCost = basePrice * days;
			string placeholder = "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "): " + daysCost + " zł\r\n";
			var finalResult = daysCost;

			var carClassCost = daysCost * ((int)carClass) / 10;
			finalResult += carClassCost;
			placeholder += "Cena klasy pojazdu: " + carClassCost + " zł\r\n";

			if (today.Year - data.year < 5)
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

			var fuelCost = data.distance / 100 * fuelConsumption * fuelPrice;
			placeholder += "Cena paliwa: " + fuelCost + " zł\r\n";
			finalResult += fuelCost;

			placeholder += "---------------------------------------\r\n";
			placeholder += "Razem: " + finalResult + " zł";

			return Ok(placeholder);
		}
	}
}