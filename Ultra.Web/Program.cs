using Ultra.Infrastructure.DependencyInjection;
using Ultra.Web.Startups;
using Ultra.Web.Startups.Helpers;

var builder = WebApplication.CreateBuilder(args);
var activator = new ActivatorDependencyResolver();
var app = await AppBuilder.New(activator)
    .With<Startup>()
    .With<HttpStartup>()
    .With<HttpPollyStartup>()
    .With<MqLocalMediatRStartup>()
    .With<ConfigurationStartup>()
    .With<HstsStartup>()
    .With<RoutingStartup>()
    .With<SwaggerStartup>()
    .With<VersioningStartup>()
    .With<WebApiStartup>()

    .BuildAsync(builder);

await app.RunAsync();
