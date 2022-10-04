using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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