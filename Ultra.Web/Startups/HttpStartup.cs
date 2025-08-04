using Ultra.Core.Startups;
using Ultra.Core.Http;

namespace Ultra.Web.Startups;

public class HttpStartup : ServiceStartup
{
    public override ValueTask<IServiceCollection> AddAsync(
        IServiceCollection services,
        WebApplicationBuilder builder)
    {
        services.AddBatchHttp();

        return ValueTask.FromResult(services);
    }
}
