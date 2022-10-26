using System.Reflection;
using Application.Repositories;
using DataAcces.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DataAcces;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        
        services.AddTransient<ICarRepository, CarRepository>();
        services.AddTransient<ICarReservationService, CarReservationService>();

        return services;
    }
}