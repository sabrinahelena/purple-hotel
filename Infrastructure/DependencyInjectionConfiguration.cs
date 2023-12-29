using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterApplicationExternalDependencies(this IServiceCollection services)
        {

            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddScoped<PurpleHotelContext, PurpleHotelContext>();

            return services;

        }
    }
}
