using BuracoNasLetras.App.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuracoNasLetras.App
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

            services.AddMvcConfiguration();

            services.RegisterServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvcConfiguration(env);
        }
    }
}
