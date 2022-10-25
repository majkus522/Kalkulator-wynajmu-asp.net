using Microsoft.AspNetCore.Mvc;
using DataAcces;
using Domain;
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

<<<<<<< Updated upstream
		/*[HttpPut("{id}")]
		public async Task<string> Put(int Id, Car Car)
		{
			var result = await _calculator.put(Id, Car);
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}*/
=======
		[HttpPut("{id}")]
		public async Task<string> PutReservation(int Id, [FromQuery] InputData Data)
		{
			Console.WriteLine("majkus522" + "{" + Id + ";" + Data.Start + ";" + Data.End + ";" + Data.Distance + ";" + Data.Year + "}");
			var request = new CheckCarReservationQuery(Id, Data.Distance, Data.Year, Data.Start, Data.End);
			var valid = await _mediator.Send(request);
			if(valid)
			{
				var putRequest = new PutReservationCommand(Id, Data.Distance, Data.Year, Data.Start, Data.End);
				await _mediator.Send(putRequest);
				return "Dokonano rezerwacji.";
			}
			return "Brak dostepnych pojazdów w tym terminie.";
		}
>>>>>>> Stashed changes

		[HttpPost]
		public async Task<ActionResult<Car>> AddCar(AddCarRequest Car)
		{
			var Id = await _calculator.AddCar(Car);
			return CreatedAtAction(nameof(AddCar), new { id = Id }, Car);
		}
	}
}