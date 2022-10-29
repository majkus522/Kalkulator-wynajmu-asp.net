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
					BasePrice = 36.99f,
					FuelConsumption = 5.81f,
					CarClass = CarClassE.Standard,
					ProductionDate = new DateTime(2000, 10, 1),
					RegistrationNumber = "RZE 12345",
					CarState = CarStateE.avaliable
				},
				new Car()
				{
					Id = 2,
					Brand = "BMW",
					Model = "M3 TOURING",
					BasePrice = 69.99f,
					FuelConsumption = 10.4f,
					CarClass = CarClassE.Premium,
					ProductionDate = new DateTime(2000, 10, 2),
					RegistrationNumber = "RZE 15345",
					CarState = CarStateE.avaliable
				},
				new Car()
				{
					Id = 3,
					Brand = "Audi",
					Model = "A1 Sportback",
					BasePrice = 45.99f,
					FuelConsumption = 5.6f,
					CarClass = CarClassE.Medium,
					ProductionDate = new DateTime(2000, 11, 1),
					RegistrationNumber = "RZE 74812",
					CarState = CarStateE.avaliable
				},
				new Car()
				{
					Id = 4,
					Brand = "Audi",
					Model = "A1 Sportback",
					BasePrice = 45.99f,
					FuelConsumption = 5.6f,
					CarClass = CarClassE.Medium,
					ProductionDate = new DateTime(2000, 11, 1),
					RegistrationNumber = "RZE 74812",
					CarState = CarStateE.avaliable
				},
				new Car()
				{
					Id = 5,
					Brand = "Audi",
					Model = "A1 Sportback",
					BasePrice = 45.99f,
					FuelConsumption = 5.6f,
					CarClass = CarClassE.Medium,
					ProductionDate = new DateTime(2000, 11, 1),
					RegistrationNumber = "RZE 74812",
					CarState = CarStateE.inRepair
				}
			});
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connection);
		}
	}
}