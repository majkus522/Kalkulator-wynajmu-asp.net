using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcces.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false),
                    FuelConsumption = table.Column<float>(type: "real", nullable: false),
                    CarClass = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "Brand", "CarClass", "CarState", "FuelConsumption", "Model", "ProductionDate", "RegistrationNumber" },
                values: new object[,]
                {
                    { 1, 36.99f, "Skoda", 20, 0, 5.81f, "KAMIQ", new DateTime(2000, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RZE 12345" },
                    { 2, 69.99f, "BMW", 40, 0, 10.4f, "M3 TOURING", new DateTime(2000, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "RZE 15345" },
                    { 3, 45.99f, "Audi", 30, 0, 5.6f, "A1 Sportback", new DateTime(2000, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RZE 74812" },
                    { 4, 45.99f, "Audi", 30, 0, 5.6f, "A1 Sportback", new DateTime(2000, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RZE 74812" },
                    { 5, 45.99f, "Audi", 30, 2, 5.6f, "A1 Sportback", new DateTime(2000, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RZE 74812" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
