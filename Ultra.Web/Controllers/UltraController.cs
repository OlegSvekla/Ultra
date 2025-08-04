using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Ultra.Contracts.Queries;
using Ultra.Contracts.Rss;
using Ultra.Core.Mappers;
using Ultra.Core.Mq.Buses;
using Ultra.Web.Rqs;
using Ultra.Web.Rss;
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
public class UltraController(
    ILocalMessageBus localMessageBus,
    IMapper<GetPaymentRq, GetPaymentQuery> getPaymentRqToQueryMapper,
    IMapper<GetPaymentQueryRs, GetPaymentRs> getPaymentQueryRsToRsMapper
    ) : ControllerBase
{
    [HttpPost("payments/info")]
    [ProducesResponseType(Status200OK, Type = typeof(GetPaymentRs))]
    public async Task<IActionResult> GetEventsAsync(
        [FromBody] GetPaymentRq rq,
        CancellationToken ct)
    {
        var query = getPaymentRqToQueryMapper.Map(rq);

        var queryRs = await localMessageBus.DispatchAsync(query, ct);

        var rs = getPaymentQueryRsToRsMapper.Map(queryRs);

        return Ok(rs);
    }
}
