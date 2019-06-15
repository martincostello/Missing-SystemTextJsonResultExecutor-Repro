using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace MissingSystemTextJsonResultExecutor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = services
                .AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddJsonOptions(options => options.JsonSerializerOptions.WriteIndented = true);

            // Uncomment the line below to get the application to work
            // builder.AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
