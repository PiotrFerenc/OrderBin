using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using OrderBin.Modules.Products.Core;

[assembly:InternalsVisibleTo("OrderBin.Bootstrapper")]
namespace OrderBin.Modules.Products.Api
{
    public static class Extensions
    {
        internal static IServiceCollection AddProducts(this IServiceCollection service)
        {
            service.AddCore();
            
            return service;
        }
    }
}