using Ultra.Core.Startups;

namespace Ultra.Web.Startups;

public interface IAppStartup : ICustomStartup
{
}

public abstract class AppStartup
    : BaseStartup, IAppStartup
{
    public override ValueTask<IServiceCollection> AddAsync(
        IServiceCollection services,
        WebApplicationBuilder appBuilder)
        => ValueTask.FromResult(services);
}
