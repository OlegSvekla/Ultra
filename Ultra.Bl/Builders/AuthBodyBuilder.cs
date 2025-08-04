using Ultra.Contracts.Queries;

namespace Ultra.Bl.Builders;

public class AuthBodyBuilder
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

    private AuthBodyBuilder()
    {
    }

    public static AuthBodyBuilder Create()
        => new AuthBodyBuilder();

    public AuthBodyBuilder WithCode(string code)
    {
        data[Code] = code;
        return this;
    }

    public AuthBodyBuilder WithClientID(string clientID)
    {
        data[ClientID] = clientID;
        return this;
    }

    public AuthBodyBuilder WithClientIP(string clientIP)
    {
        data[ClientIP] = clientIP;
        return this;
    }

    public AuthBodyBuilder WithClientDateCreated(DateTime clientDateCreated)
    {
        data[ClientDateCreated] = clientDateCreated;
        return this;
    }

    public AuthBodyBuilder WithPaymentMethod(string paymentMethod)
    {
        data[PaymentMethod] = paymentMethod;
        return this;
    }

    public AuthBodyBuilder WithIdTransactionMerchant(string idTransactionMerchant)
    {
        data[IdTransactionMerchant] = idTransactionMerchant;
        return this;
    }

    public AuthBodyBuilder WithAmount(decimal amount)
    {
        data[Amount] = amount;
        return this;
    }

    public AuthBodyBuilder WithIntegrationMerchantData(IntegrationMerchantQuery integrationMerchantData)
    {
        data[IntegrationMerhcnatData] = integrationMerchantData;
        return this;
    }

    public IDictionary<string, object> Build()
        => data;
}
