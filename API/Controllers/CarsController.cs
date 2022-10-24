using Microsoft.AspNetCore.Mvc;
using DataAcces;
using Domain;
using Common;
using Application;
using API.Functions.Query;
using MediatR;

namespace API.Controllers
{
	[ApiController]
	[Route("api/kalkulator")]
	public class CarsController : ControllerBase
	{
		private readonly ICalculator _calculator;
        private readonly IMediator _mediator;

        public CarsController(DatabaseContext context, IMediator mediator)
		{
            _calculator = new Calculator(new CarRepository(context));
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ICollection<Car>> GetCars()
		{
			/*var result = await _calculator.GetCars();
			HttpContext.Response.StatusCode = result.code;
			return result.content;*/

			var request = new GetAllCarsQuery()
			{
				calculator = _calculator
			};
            var result = await _mediator.Send(request);

            return result;
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
		public async Task<ActionResult<Car>> AddCar(AddCarRequest Car)
		{
			var Id = await _calculator.AddCar(Car);
			return CreatedAtAction(nameof(AddCar), new { id = Id }, Car);
		}
	}
}