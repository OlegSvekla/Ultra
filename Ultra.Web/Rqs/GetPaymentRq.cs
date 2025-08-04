using Ultra.Core.Attributes;
using Ultra.Core.Enums;

namespace Ultra.Web.Rqs;

public record GetPaymentRq(
    string ClientID,
    string ClientIP,
    DateTime ClientDateCreated,
    [property: FromEnum(typeof(PaymentMethodEnum))]
    string PaymentMethod,
    string IdTransactionMerchant,
    decimal Amount,
    IntegrationMerchantRq IntegrationMerhcnatRq
);

public record IntegrationMerchantRq(string WebHook);
