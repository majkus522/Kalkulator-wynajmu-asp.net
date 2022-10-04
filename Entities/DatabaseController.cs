using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KalkulatorWynajmu.Entities
{
	public class DatabaseController : DbContext
	{
		public DbSet<Car> cars;

		string connection = "Server=(localdb)\\mssqllocaldb;Database=CrasDB;Trusted_Connection=True;";

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>().Property(r => r.brand).IsRequired();
			modelBuilder.Entity<Car>().Property(r => r.model).IsRequired();

			modelBuilder.Entity<Car>().HasData(new Car[]
			{
				new Car()
				{
					Id = 1,
					brand = "Skoda",
					model = "KAMIQ",
					carAvaliable = 10,
					basePrice = 36.99f,
					fuelConsumption = 5.81f,
					carClass = Controllers.CarClass.Standard
				},
				new Car()
				{
					Id = 2,
					brand = "BMW",
					model = "M3 TOURING",
					carAvaliable = 1,
					basePrice = 69.99f,
					fuelConsumption = 10.4f,
					carClass = Controllers.CarClass.Premium
				},
				new Car()
				{
					Id = 3,
					brand = "Audi",
					model = "A1 Sportback",
					carAvaliable = 1,
					basePrice = 45.99f,
					fuelConsumption = 5.6f,
					carClass = Controllers.CarClass.Medium
				}
			});
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connection);
		}
	}
}