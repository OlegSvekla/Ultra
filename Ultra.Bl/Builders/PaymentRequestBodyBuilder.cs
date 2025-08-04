using Ultra.Contracts.Queries;

namespace Ultra.Bl.Builders;

public class PaymentRequestBodyBuilder
{
    private const string Code = "Code";
    private const string ClientID = "ClientID";
    private const string ClientIP = "ClientIP";
    private const string ClientDateCreated = "ClientDateCreated";
    private const string PaymentMethod = "PaymentMethod";
    private const string IdTransactionMerchant = "IdTransactionMerchant";
    private const string Amount = "Amount";
    private const string IntegrationMerhcnatData = "IntegrationMerhcnatData";

    private readonly IDictionary<string, object> data = new Dictionary<string, object>();

    private PaymentRequestBodyBuilder()
    {
    }

    public static PaymentRequestBodyBuilder Create()
        => new PaymentRequestBodyBuilder();

    public PaymentRequestBodyBuilder WithCode(string code)
    {
        data[Code] = code;
        return this;
    }

    public PaymentRequestBodyBuilder WithClientID(string clientID)
    {
        data[ClientID] = clientID;
        return this;
    }

    public PaymentRequestBodyBuilder WithClientIP(string clientIP)
    {
        data[ClientIP] = clientIP;
        return this;
    }

    public PaymentRequestBodyBuilder WithClientDateCreated(DateTime clientDateCreated)
    {
        data[ClientDateCreated] = clientDateCreated;
        return this;
    }

    public PaymentRequestBodyBuilder WithPaymentMethod(string paymentMethod)
    {
        data[PaymentMethod] = paymentMethod;
        return this;
    }

    public PaymentRequestBodyBuilder WithIdTransactionMerchant(string idTransactionMerchant)
    {
        data[IdTransactionMerchant] = idTransactionMerchant;
        return this;
    }

    public PaymentRequestBodyBuilder WithAmount(decimal amount)
    {
        data[Amount] = amount;
        return this;
    }

    public PaymentRequestBodyBuilder WithIntegrationMerchantData(IntegrationMerchantQuery integrationMerchantData)
    {
        data[IntegrationMerhcnatData] = integrationMerchantData;
        return this;
    }

    public IDictionary<string, object> Build()
        => data;
}
