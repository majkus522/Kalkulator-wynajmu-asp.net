using Application;
using DataAcces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Application.Repositories;
using DataAcces.EF;
using DataAcces.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CrasDB;Trusted_Connection=True;"));

builder.Services.AddMvc();
builder.Services.AddApplication();
builder.Services.AddDataAccess();

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