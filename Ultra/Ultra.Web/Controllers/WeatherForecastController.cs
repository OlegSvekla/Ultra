using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace Ultra.Web.Controllers;

[ApiController]
[ApiVersion(1)]
[Route("api/v{version:apiVersion}/[controller]")]
[Consumes(MediaTypeNames.Application.Json)]
[Produces(MediaTypeNames.Application.Json)]
[ProducesResponseType(Status400BadRequest, Type = typeof(FieldErrorRs[]))]
[ProducesResponseType(Status500InternalServerError, Type = typeof(MessageErrorRs))]
[ProducesResponseType(Status429TooManyRequests, Type = typeof(void))]
public class WeatherForecastController(
    ILocalMessageBus localMessageBus,
    IMapper<GetMeteoriteFilterRq, GetMeteoriteFilterQuery> meteoriteFilterRqToQueryMapper,
    IMapper<IReadOnlyCollection<GetMeteoriteFilterQueryRs>, IReadOnlyCollection<GetMeteoriteFilterRs>> meteoriteFilterQueryRsToRsMapper)
    : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
