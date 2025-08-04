using Ultra.Core.Startups;

namespace Ultra.Web.Startups;

public class ConfigurationStartup : ServiceStartup
{
    public override ValueTask<IServiceCollection> AddAsync(IServiceCollection services, WebApplicationBuilder builder)
    {
        builder.Configuration
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables(prefix: "Irlix__");

        return ValueTask.FromResult(services);
    }
}
