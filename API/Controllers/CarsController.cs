using Microsoft.AspNetCore.Mvc;
using DataAcces;
using Domain;
using Infrastructure;
using Common;

namespace API.Controllers
{
	[ApiController]
	[Route("api/kalkulator")]
	public class CarsController : ControllerBase
	{
		private readonly ICalculator _calculator;

		public CarsController(DatabaseContext context)
		{
			_calculator = new Calculator(new CarRepository(context));
		}

		[HttpGet]
		public async Task<string> GetCars()
		{
			var result = await _calculator.GetCars();
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpGet("{id}")]
		public async Task<string> Get(int Id, [FromQuery] InputData Data)
		{
			var result = await _calculator.Get(Id, Data);
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		/*[HttpPut("{id}")]
		public async Task<string> Put(int Id, Car Car)
		{
			var result = await _calculator.put(Id, Car);
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}*/

		[HttpPost]
		public async Task<string> PostCar(CarRequest Car)
		{
			await _calculator.PostCar(Car);
			return "dodano car";
		}
	}
}