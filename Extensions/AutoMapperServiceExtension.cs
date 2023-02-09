using CostIt.Application.Utilities;
using System.Net.NetworkInformation;

namespace CostIt.Api.Extensions
{
    public static class AutoMapperServiceExtension
    {
        public static void ConfigureAutoMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapInitilizer));
        }
    }
}
