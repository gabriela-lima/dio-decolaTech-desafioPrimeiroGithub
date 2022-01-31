using DIO.Series.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace DIO.Series.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepositorio<Serie>, SerieRepositorio>();
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
