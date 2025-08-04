using Ultra.Core.Mq.Buses;
using Microsoft.Extensions.DependencyInjection;

namespace Ultra.Infrastructure.Mq;

public static class Bootstrap
{
    public static void AddBatchMqLocalMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg
            => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        services.AddScoped<ILocalMessageBus, MediatrLocalMessageBus>();
        services.AddScoped<IMediatrLocalMessageBus, MediatrLocalMessageBus>();
    }
}
