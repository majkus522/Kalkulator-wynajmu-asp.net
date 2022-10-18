using Common;
using DataAcces;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Application
{
	public class Calculator : ICalculator
	{
		public async Task<Result> get(int id, InputData Data, DatabaseContext context)
		{
			var placeholder = "";
			var car = await context.Cars.FindAsync(id);
			if (car == null)
				return new Result(404, "");
			placeholder += car.Brand + " " + car.Model + "\r\n\r\n";
			var today = DateTime.Today;
			if (today > Data.Start)
			{
				return new Result(400, "Niepoprawna data rozpoczęcia wynajmu");
			}
			if (today > Data.End || Data.End < Data.Start)
			{
				return new Result(400, "Niepoprawna data zakończenia wynajmu");
			}
			if (Data.Distance < 0)
			{
				return new Result(400, "Niepoprawna odległość");
			}
			if (Data.Year < 1900)
			{
				return new Result(400, "Niepoprawny rok wydania prawa jazdy");
			}

			var fuelPrice = 6.96f;

			if (today.Year - Data.Year < 3 && car.CarClass == CarClassE.Premium)
				return new Result(400, "Nie możesz wyporzyczyć tego pojazdu");

			var days = Data.End.Subtract(Data.Start).Days;
			var daysCost = car.BasePrice * days;
			placeholder += "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "): " + Math.Round(daysCost, 2) + " zł\r\n";
			var finalResult = daysCost;

			var carClassCost = daysCost * car.CarClass.getValue() / 10;
			finalResult += carClassCost;
			placeholder += "Cena klasy pojazdu: " + Math.Round(carClassCost, 2) + " zł\r\n";

			if (today.Year - Data.Year < 5)
			{
				var expirienceCost = .2f * finalResult;
				placeholder += "Niedoświadczony kierowca: " + Math.Round(expirienceCost, 2) + " zł\r\n";
				finalResult += expirienceCost;
			}

			if (car.CarAvaliable < 3)
			{
				var modelCountCost = .15f * finalResult;
				placeholder += "Mała ilośc pojazdów: " + Math.Round(modelCountCost, 2) + " zł\r\n";
				finalResult += modelCountCost;
			}

			var fuelCost = Data.Distance / 100 * car.FuelConsumption * fuelPrice;
			placeholder += "Cena paliwa: " + Math.Round(fuelCost, 2) + " zł\r\n";
			finalResult += fuelCost;

			placeholder += "---------------------------------------\r\n";
			placeholder += "Razem: " + Math.Round(finalResult, 2) + " zł";

			return new Result(200, placeholder);
		}

		public async Task<Result> getCars(DatabaseContext context)
		{
			var placeholder = "Dostępne samochody:";
			int index = 1;
			foreach (Car car in await context.Cars.ToListAsync())
			{
				placeholder += "\r\n" + index + ". " + car.Brand + " " + car.Model;
				index++;
			}
			return new Result(200, placeholder);
		}

		public async Task postCar(Car car, DatabaseContext context)
		{
			context.Cars.Add(car);
			await context.SaveChangesAsync();
		}

		public async Task<Result> put(int id, Car car, DatabaseContext context)
		{
			if (id != car.Id)
			{
				return new Result(400, "");
			}

			context.Entry(car).State = EntityState.Modified;

			try
			{
				await context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CarExists(id, context))
				{
					return new Result(404, "");
				}
				else
				{
					throw;
				}
			}

			return new Result(204, "");
		}

		bool CarExists(int id, DatabaseContext context)
		{
			return context.Cars.Any(e => e.Id == id);
		}
	}
}