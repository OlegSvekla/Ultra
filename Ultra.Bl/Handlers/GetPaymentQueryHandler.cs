using Microsoft.Extensions.Logging;
using System.Text.Json;
using Ultra.Bl.Builders;
using Ultra.Contracts.Queries;
using Ultra.Contracts.Rss;
using Ultra.Core.Http.Out;
using Ultra.Core.Http.Out.Helpers;
using Ultra.Core.Http.Out.Models;
using Ultra.Infrastructure.Mq.Handlers;

namespace Ultra.Bl.Handlers;

public class GetPaymentQueryHandler(
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

            var body = PaymentRequestBodyBuilder.Create()
                .WithClientID(query.ClientID)
                .WithClientIP(query.ClientIP)
                .WithClientDateCreated(query.ClientDateCreated)
                .WithPaymentMethod(query.PaymentMethod)
                .WithIdTransactionMerchant(query.IdTransactionMerchant)
                .WithAmount(query.Amount)
                .WithIntegrationMerchantData(query.IntegrationMerhcnatData)
                .Build();

            Console.WriteLine("Request body:");
            Console.WriteLine(JsonSerializer.Serialize(body, new JsonSerializerOptions { WriteIndented = true }));

            var headers = new Dictionary<string, string>()
                .AddAuthBearerToken($"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJCdXNpbmVzc0ludGVncmF0aW9uIiwibmJmIjoxNzQzNzIwMTk1LCJleHAiOjE3NzUyNTYxOTUsImlzcyI6Ik5QIiwiYXVkIjoiTlBTZXJ2aWNlcyJ9.U-b0GjRCWcieRJCQN9BKF7C-zdWropPct084cO2x5mk");

            var rq = new HttpWithBodyRq<IDictionary<string, object>>(
                Uri: uri,
                Method: method,
                Body: body,
                Headers: headers);

            var data = await httpSender.ForceSendAsync<IDictionary<string, object>, GetPaymentQueryRs>(
                rq: rq,
                ct: ct);

            Console.WriteLine("Response data:");
            Console.WriteLine(JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));

            return data;
        }
        catch (Exception)
        {
            logger.LogWarning($"Error occurred while fetching data.");
            throw;
        }
    }
}
