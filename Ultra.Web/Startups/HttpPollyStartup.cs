using Ultra.Core.Startups;
using Ultra.Infrastructure.Http.Polly;

namespace Ultra.Web.Startups;

public class HttpPollyStartup : ServiceStartup
{
    public override ValueTask<IServiceCollection> AddAsync(
        IServiceCollection services,
        WebApplicationBuilder builder)
    {
        services.AddBatchHttpPolly(builder.Configuration);

        return ValueTask.FromResult(services);
    }
}
