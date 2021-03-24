using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BuracoNasLetras.Api.Configurations
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "BuracoNasLetras.Api",
                    Description = "API para realizar um POST e retornar os dados solicitados pelo teste",
                    Version = "v1",
                    Contact = new OpenApiContact() { Name = "Yuri Siman", Email = "contato@yurisiman.com.br" }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BuracoNasLetras.Api v1"));

            return app;
        }
    }
}