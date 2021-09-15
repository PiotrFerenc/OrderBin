using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OrderBin.Infrastructure.Api;

[assembly: InternalsVisibleTo("OrderBin.Bootstrapper")]

namespace OrderBin.Infrastructure
{
    public static class Extensions
    {
        internal static IServiceCollection AddInfrastructure(this IServiceCollection service)
        {
            service.AddControllers().ConfigureApplicationPartManager(
                manager => { manager.FeatureProviders.Add(new InternalControllerFeatureProvider()); }
            );

            return service;
        }

        internal static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", context => context.Response.WriteAsync("Works"));
            });


            return app;
        }
    }
}