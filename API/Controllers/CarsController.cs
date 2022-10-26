using Microsoft.AspNetCore.Mvc;
using DataAcces;
using Domain;
using Common;
using Application;
using MediatR;
using Application.Cars.Commands;
using Application.Cars.Queries;
using Application.Cars.Requests;
using Application.Repositories;
using Application.Reservations.Commands;
using DataAcces.EF;
using DataAcces.Repositories;
using Domain.Cars;

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
			var request = new GetAllCarsQuery();
			var result = await _mediator.Send(request);
			return result;
		}

		[HttpGet("{id}")]
		public async Task<string> Get(int Id, [FromQuery] InputData Data)
		{
			var request = new GetCarQuery(Id);
			var car = await _mediator.Send(request);
			var result = await _calculator.Get(car, Data);
			HttpContext.Response.StatusCode = result.code;
			return result.content;
		}

		[HttpPost]
		public async Task<ActionResult<Car>> AddCar(AddCarRequest Car)
		{
			var request = new AddCarCommand(Car);
			var Id = await _mediator.Send(request);
			return CreatedAtAction(nameof(AddCar), new { id = Id }, Car);
		}

		[HttpPut("{id}")]
		public async Task<string> PutReservation(int Id, [FromQuery] InputData Data)
		{
			var request = new PutReservationCommand(Id, Data.Distance, Data.Year, Data.Start, Data.End);
			var valid = await _mediator.Send(request);
			if (valid)
			{
				return "Dokonano rezerwacji.";
			}
			return "Brak dostepnych pojazd?w w tym terminie.";
		}
	}
}