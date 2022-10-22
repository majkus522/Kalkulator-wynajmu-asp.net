using Application;
using DataAcces;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CrasDB;Trusted_Connection=True;"));
//builder.Services.AddSingleton<ICalculator, Calculator>();
//builder.Services.AddSingleton<ICarRepository, CarRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();