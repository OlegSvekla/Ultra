using Ultra.Core.Enums;
using Ultra.Core.Startups;
using Ultra.Infrastructure.Mq;

namespace Ultra.Web.Startups;

/// <summary>
/// MediatR local message queue services.
/// </summary>
public sealed class MqLocalMediatRStartup : ServiceStartup
{
    public override ServiceRegistrationOrderEnum ServiceRegistrationOrder
        => ServiceRegistrationOrderEnum.Highest;

    public override ValueTask<IServiceCollection> AddAsync(
        IServiceCollection services,
        WebApplicationBuilder builder)
    {
        services.AddBatchMqLocalMediatR();

        return ValueTask.FromResult(services);
    }
}
