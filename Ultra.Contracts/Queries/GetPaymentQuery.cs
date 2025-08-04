using Ultra.Contracts.Rss;
using Ultra.Infrastructure.Mq.Messages;

namespace Ultra.Contracts.Queries;

public record GetPaymentQuery(
    string ClientID,
    string ClientIP,
    DateTime ClientDateCreated,
    string PaymentMethod,
    string IdTransactionMerchant,
    decimal Amount,
    IntegrationMerchantQuery IntegrationMerhcnatData
) : IMediatrQuery<GetPaymentQueryRs>;

public record IntegrationMerchantQuery(string WebHook);
