using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

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
		public IActionResult Get([FromQuery] int distance, [FromQuery] int year, [FromQuery] DateTime start, [FromQuery] DateTime end, [FromQuery] CarClass carClass)
		{
			DateTime today = DateTime.Today;
			float fuelPrice = 6.96f;
			float basePrice = 40;
			float fuelConsumption = 7.5f;
			int modelAvaliable = 1;

			int days = end.Subtract(start).Days;
			float daysCost = basePrice * days;
			float finalResult = daysCost;

			float carClassCost = 0;
			switch (carClass)
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

			float expirienceCost = 0;
			if (today.Year - year < 5)
			{
				expirienceCost = .2f * finalResult;
				finalResult += expirienceCost;
			}

			float modelCountCost = 0;
			if (modelAvaliable < 3)
			{
				modelCountCost = .15f * finalResult;
				finalResult += modelCountCost;
			}

			float fuelCost = distance / 100 * fuelConsumption * fuelPrice;
			finalResult += fuelCost;

			return new JsonResult(new Dictionary<string, float>()
			{
				{ "baseCost", daysCost},
				{ "expirienceCost", expirienceCost},
				{ "modelCountCost", modelCountCost},
				{ "fuelCost", fuelCost},
				{ "sum", finalResult}
			});
		}
	}
}