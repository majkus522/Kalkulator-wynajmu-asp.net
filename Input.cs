using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalkulatorWynajmu
{
	[BindProperties]
	public class InputData
	{
		public int distance { get; set; }
		public int year { get; set; }
		public DateTime start { get; set; }
		public DateTime end { get; set; }
	}
}