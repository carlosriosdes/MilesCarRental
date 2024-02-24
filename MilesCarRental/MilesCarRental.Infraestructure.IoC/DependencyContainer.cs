using Microsoft.Extensions.DependencyInjection;
using MilesCarRental.Application.Contracts;
using MilesCarRental.Application.Services;
using MilesCarRental.Domain.Contracts;
using MilesCarRental.Infraestructure.Data.Repositories;

namespace MilesCarRental.Infraestructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IVehiculoService, VehiculoService>();

            services.AddScoped<IVehiculoRepository, VehiculoRepository>();
        }
    }
}
