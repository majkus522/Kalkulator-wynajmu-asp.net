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
                    CarAvaliable = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false),
                    FuelConsumption = table.Column<float>(type: "real", nullable: false),
                    CarClass = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "BasePrice", "Brand", "CarAvaliable", "CarClass", "FuelConsumption", "Model" },
                values: new object[] { 1, 36.99f, "Skoda", 10, 20, 5.81f, "KAMIQ" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "Brand", "CarAvaliable", "CarClass", "FuelConsumption", "Model" },
                values: new object[] { 2, 69.99f, "BMW", 1, 40, 10.4f, "M3 TOURING" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "Brand", "CarAvaliable", "CarClass", "FuelConsumption", "Model" },
                values: new object[] { 3, 45.99f, "Audi", 1, 30, 5.6f, "A1 Sportback" });
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
