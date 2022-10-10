using DataAcces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Infrastructure;
using Common;

namespace API.Controllers
{
	[ApiController]
	[Route("api/kalkulator")]
	public class CarsController : ControllerBase
	{
		readonly DatabaseContext context;
		readonly ICalculator calculator;

		public CarsController(DatabaseContext context, ICalculator calculator)
		{
			this.context = context;
			this.calculator = calculator;
		}

		[HttpGet]
		public async Task<string> getCars()
		{
			var result = calculator.getCars(context).Result;
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpGet("{id}")]
		public async Task<string> get(int id, [FromQuery] InputData Data)
		{
			var result = calculator.get(id, Data, context).Result;
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpPut("{id}")]
		public async Task<string> put(int id, Car car)
		{
			var result = calculator.put(id, car, context).Result;
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpPost]
		[ActionName(nameof(PostCar))]
		public async Task<ActionResult<Car>> PostCar(Car car)
		{
			calculator.postCar(car, context);
			return CreatedAtAction(nameof(PostCar), new { id = car.Id }, car);
		}
	}
}