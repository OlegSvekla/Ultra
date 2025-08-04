namespace Ultra.Web.Rqs;

public record GetPaymentRq(
    string ClientID,
    string ClientIP,
    DateTime ClientDateCreated,
    string PaymentMethod,
    string IdTransactionMerchant,
    decimal Amount,
    IntegrationMerchantRq IntegrationMerhcnatRq
);

public record IntegrationMerchantRq(string WebHook);
