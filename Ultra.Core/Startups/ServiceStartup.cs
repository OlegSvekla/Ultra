using Microsoft.AspNetCore.Builder;
using Ultra.Core.Enums;

namespace Ultra.Core.Startups;

public interface IServiceStartup : ICustomStartup
{
}

public abstract class ServiceStartup
    : BaseStartup,
    IServiceStartup
{
    public override MiddlewareOrderEnum MiddlewareOrder
        => MiddlewareOrderEnum.Asap;

    public override ValueTask<WebApplication> UseAsync(
        WebApplication app)
        => ValueTask.FromResult(app);
}
