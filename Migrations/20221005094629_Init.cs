using Microsoft.EntityFrameworkCore.Migrations;

namespace KalkulatorWynajmu.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carAvaliable = table.Column<int>(type: "int", nullable: false),
                    basePrice = table.Column<float>(type: "real", nullable: false),
                    fuelConsumption = table.Column<float>(type: "real", nullable: false),
                    carClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "basePrice", "brand", "carAvaliable", "carClass", "fuelConsumption", "model" },
                values: new object[] { 1, 36.99f, "Skoda", 10, 13, 5.81f, "KAMIQ" });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "basePrice", "brand", "carAvaliable", "carClass", "fuelConsumption", "model" },
                values: new object[] { 2, 69.99f, "BMW", 1, 20, 10.4f, "M3 TOURING" });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "basePrice", "brand", "carAvaliable", "carClass", "fuelConsumption", "model" },
                values: new object[] { 3, 45.99f, "Audi", 1, 16, 5.6f, "A1 Sportback" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
