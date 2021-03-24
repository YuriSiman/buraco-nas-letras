using BuracoNasLetras.Api.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuracoNasLetras.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextConfiguration(Configuration);

            services.AddAutoMapper(typeof(Startup));

            services.AddApiConfiguration();

            services.AddSwaggerConfiguration();

            services.RegisterServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwaggerConfiguration();

            app.UseApiConfiguration(env);
        }
    }
}
