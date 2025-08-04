using Ultra.Core.Enums;
using Ultra.Core.Startups;
using Ultra.Web.Mappers;
using Ultra.Core.Serializers;

namespace Ultra.Web.Startups;

internal sealed class Startup : ServiceStartup
{
    public override ServiceRegistrationOrderEnum ServiceRegistrationOrder
        => ServiceRegistrationOrderEnum.Highest;

    public override ValueTask<IServiceCollection> AddAsync(
        IServiceCollection services,
        WebApplicationBuilder builder)
    {
        services.AddWebMappers();
        services.AddBatchSerializers();

        builder.Services.AddHttpClient();

        return ValueTask.FromResult(services);
    }
}
