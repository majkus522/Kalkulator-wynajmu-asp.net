using Common;
using Application;
using Domain;

namespace DataAcces
{
	public class Calculator : ICalculator
	{
		private readonly ICarRepository _carRepository;

		public Calculator(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<Result> Get(int id, InputData Data)
		{
			var result = "";
			var car = await _carRepository.Get(id);
			if (car == null)
				return new Result(404, "");
			result += car.Brand + " " + car.Model + "\r\n\r\n";
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
			if (Data.Year < 1950)
			{
				return new Result(400, "Niepoprawny rok wydania prawa jazdy");
			}

			var fuelPrice = 6.96f;

			if (today.Year - Data.Year < 3 && car.CarClass == CarClassE.Premium)
				return new Result(400, "Nie możesz wyporzyczyć tego pojazdu");

			var days = Data.End.Subtract(Data.Start).Days;
			var daysCost = car.BasePrice * days;
			result += "Cena bazowa (" + days + " " + (days == 1 ? "dzień" : "dni") + "): " + Math.Round(daysCost, 2) + " zł\r\n";
			var finalResult = daysCost;

			var carClassCost = daysCost * car.CarClass.GetValue() / 10;
			finalResult += carClassCost;
			result += "Cena klasy pojazdu: " + Math.Round(carClassCost, 2) + " zł\r\n";

			if (today.Year - Data.Year < 5)
			{
				var expirienceCost = .2f * finalResult;
				result += "Niedoświadczony kierowca: " + Math.Round(expirienceCost, 2) + " zł\r\n";
				finalResult += expirienceCost;
			}

			if (car.CarAvaliable < 3)
			{
				var modelCountCost = .15f * finalResult;
				result += "Mała ilośc pojazdów: " + Math.Round(modelCountCost, 2) + " zł\r\n";
				finalResult += modelCountCost;
			}

			var fuelCost = Data.Distance / 100 * car.FuelConsumption * fuelPrice;
			result += "Cena paliwa: " + Math.Round(fuelCost, 2) + " zł\r\n";
			finalResult += fuelCost;

			result += "---------------------------------------\r\n";
			result += "Razem: " + Math.Round(finalResult, 2) + " zł";

			return new Result(200, result);
		}

		public async Task<ICollection<Car>> GetCars()
		{
			/*var result = "Dostępne samochody:";
			int index = 1;
			foreach (Car car in await _carRepository.GetAll(_carRepository.Get_context()))
			{
				result += "\r\n" + index + ". " + car.Brand + " " + car.Model;
				index++;
			}
			return new Result(200, result);*/
			return await _carRepository.GetAll();

        }

		public async Task<int> AddCar(AddCarRequest carRequest)
		{
			var car = new Car(carRequest.Brand, carRequest.Model, carRequest.CarAvaliable, carRequest.BasePrice, carRequest.FuelConsumption, carRequest.CarClass);
			return await _carRepository.Add(car);
		}

		bool CarExists(int id)
		{
			return _carRepository.Get(id) != null;
		}
	}
}