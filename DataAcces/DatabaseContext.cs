using Common;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAcces
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Car> Cars { get; set; }
		public DbSet<CarReservation> Reservations { get; set; }

		string connection = "Server=(localdb)\\mssqllocaldb;Database=CrasDB;Trusted_Connection=True;";

		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>().HasData(new Car[]
			{
				new Car()
				{
					Id = 1,
					Brand = "Skoda",
					Model = "KAMIQ",
					CarAvaliable = 10,
					BasePrice = 36.99f,
					FuelConsumption = 5.81f,
					CarClass = CarClassE.Standard
				},
				new Car()
				{
					Id = 2,
					Brand = "BMW",
					Model = "M3 TOURING",
					CarAvaliable = 1,
					BasePrice = 69.99f,
					FuelConsumption = 10.4f,
					CarClass = CarClassE.Premium
				},
				new Car()
				{
					Id = 3,
					Brand = "Audi",
					Model = "A1 Sportback",
					CarAvaliable = 1,
					BasePrice = 45.99f,
					FuelConsumption = 5.6f,
					CarClass = CarClassE.Medium
				}
			});
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connection);
		}
	}
}