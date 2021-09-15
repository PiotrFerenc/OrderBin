using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("OrderBin.Modules.Products.Api")]
namespace OrderBin.Modules.Products.Core
{
    public static class Extensions
    {
        internal static IServiceCollection AddCore(this IServiceCollection service)
        {
            return service;
        }
    }
}