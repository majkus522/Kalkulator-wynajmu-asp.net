using Microsoft.EntityFrameworkCore.Migrations;

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
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarAvaliable = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<float>(type: "real", nullable: false),
                    FuelConsumption = table.Column<float>(type: "real", nullable: false),
                    CarClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "Brand", "CarAvaliable", "CarClass", "FuelConsumption", "Model" },
                values: new object[] { 1, 36.99f, "Skoda", 10, 2, 5.81f, "KAMIQ" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "Brand", "CarAvaliable", "CarClass", "FuelConsumption", "Model" },
                values: new object[] { 2, 69.99f, "BMW", 1, 4, 10.4f, "M3 TOURING" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BasePrice", "Brand", "CarAvaliable", "CarClass", "FuelConsumption", "Model" },
                values: new object[] { 3, 45.99f, "Audi", 1, 3, 5.6f, "A1 Sportback" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
