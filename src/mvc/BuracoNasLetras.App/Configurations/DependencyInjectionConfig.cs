using BuracoNasLetras.Business.Interfaces;
using BuracoNasLetras.ConsoleApp.Extensions;
using BuracoNasLetras.Data.Context;
using BuracoNasLetras.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BuracoNasLetras.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<QuantidadeBuracosTexto>();
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IPapelRepository, PapelRepository>();

            return services;
        }
    }
}
