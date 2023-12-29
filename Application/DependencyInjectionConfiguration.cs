using Application.Services;
using Application.Services.Interface;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection ApplicationDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<IReservationService, ReservationService>();
        services.AddTransient<IReservationRepository, ReservationRepository>();
        services.AddScoped<PurpleHotelContext, PurpleHotelContext>();

        return services;
    }

}
