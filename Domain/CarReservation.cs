namespace Domain
{
	public class CarReservation
	{
		public int Id { get; set; }
		public int CarId { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public int Distance { get; set; }
		public int Year { get; set; }

		public CarReservation(int carId, DateTime start, DateTime end, int distance, int year)
		{
			CarId = carId;
			Start = start;
			End = end;
			Distance = distance;
			Year = year;
		}

		public override string ToString()
		{
			return "{" + Id + ";" + CarId + ";" + Start + ";" + End + ";" + Distance + ";" + Year + "}";
		}
	}
}