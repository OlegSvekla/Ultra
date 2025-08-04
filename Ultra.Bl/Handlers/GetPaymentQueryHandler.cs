using Microsoft.Extensions.Logging;
using Ultra.Bl.Builders;
using Ultra.Contracts.Queries;
using Ultra.Contracts.Rss;
using Ultra.Core.Http.Out;
using Ultra.Core.Http.Out.Models;
using Ultra.Infrastructure.Mq.Handlers;

namespace Ultra.Bl.Handlers;

internal class GetPaymentQueryHandler(
    IHttpSender httpSender,
    ILogger<GetPaymentQueryHandler> logger
    ) : MediatrQueryHandler<GetPaymentQuery, GetPaymentQueryRs>
{
    public override async ValueTask<GetPaymentQueryRs> HandleAsync(
        GetPaymentQuery query,
        CancellationToken ct)
    {
        try
        {
            var method = HttpMethod.Post;
            var uri = new Uri($"https://api.brusnikapay.top/host2host/payin");

            var body = AuthBodyBuilder.Create()
                .WithCode("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJCdXNpbmVzc0ludGVncmF0aW9uIiwib\r\nmJmIjoxNzQzNzIwMTk1LCJleHAiOjE3NzUyNTYxOTUsImlzcyI6Ik5QIiwiYXVkIjoiTlBTZXJ2aWNlcy J9.U-b0GjRCWcieRJCQN9BKF7C-zdWropPct084cO2x5mk")
                .Build();

            var rq = new HttpWithBodyRq<IDictionary<string, object>>(
                Uri: uri,
                Method: method,
                Body: body);

            var data = await httpSender.ForceSendAsync<GetPaymentQueryRs>(
                rq: rq,
                ct: ct);

            return data;
        }
        catch (Exception)
        {
            logger.LogWarning($"Error occurred while fetching data.");
            throw;
        }
    }
}
