using Microsoft.Extensions.DependencyInjection;
using Ultra.Core.Http.In;
using Ultra.Core.Http.Out;

namespace Ultra.Core.Http;

public static class Bootstrap
{
    public static IServiceCollection AddBatchHttp(
        this IServiceCollection services)
    {
        services.AddBatchHttpIn();
        services.AddBatchHttpOut();

        return services;
    }
}
