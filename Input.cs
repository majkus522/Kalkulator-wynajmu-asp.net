using System;

namespace KalkulatorWynajmu
{
	public record InputData
	{
		public int Distance { get; set; }
		public int Year { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
	}
}