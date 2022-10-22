using Microsoft.AspNetCore.Mvc;
using DataAcces;
using Domain;
using Infrastructure;
using Common;
using Application;

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
			var result = await _calculator.getCars();
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpGet("{id}")]
		public async Task<string> Get(int Id, [FromQuery] InputData Data)
		{
			var result = await _calculator.get(Id, Data);
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpPut("{id}")]
		public async Task<string> Put(int Id, Car Car)
		{
			var result = await _calculator.put(Id, Car);
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpPost]
		[ActionName(nameof(PostCar))]
		public async Task<ActionResult<Car>> PostCar(Car Car)
		{
			await _calculator.postCar(Car);
			return CreatedAtAction(nameof(PostCar), new { id = Car.Id }, Car);
		}
	}
}