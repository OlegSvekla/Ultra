using Newtonsoft.Json;

namespace Ultra.Contracts.Rss;

public record GetPaymentQueryRs(
    ResultQueryRs Result,
    PaymentDataQueryRs? Data,
    int TotalNumberRecords
);

public record ResultQueryRs(
    string Status,
    string XRequestId,
    string CodeError,
    string CodeErrorExt,
    string Message
);

public record PaymentDataQueryRs(
    Guid Id,
    DateTime DateAdded,
    DateTime DateUpdated,
    string TypeOperation,
    string Status,
    string IdTransactionMerchant,
    decimal AmountInitial,
    decimal AmountRandomized,
    decimal Amount,
    decimal AmountComission,
    string Currency,
    decimal AmountInCurrencyBalance,
    decimal AmountComissionInCurrencyBalance,
    decimal ExchangeRate,
    PaymentDetailsDataQueryRs PaymentDetailsData
);

public record PaymentDetailsDataQueryRs(
    string NameMediator,
    string PaymentMethod,
    string BankName,
    string Number,
    string NumberAdditional,
    string QRCode
);

//public class GetPaymentQueryRs
//{
//    [JsonProperty("result")]
//    public ResultQueryRs Result { get; set; } = default!;

//    [JsonProperty("data")]
//    public PaymentDataQueryRs? Data { get; set; }

//    [JsonProperty("totalNumberRecords")]
//    public int TotalNumberRecords { get; set; }
//}

//public class ResultQueryRs
//{
//    [JsonProperty("status")]
//    public string Status { get; set; } = default!;

//    [JsonProperty("x-request-id")]
//    public string XRequestId { get; set; } = default!;

//    [JsonProperty("codeError")]
//    public string CodeError { get; set; } = default!;

//    [JsonProperty("codeErrorExt")]
//    public string CodeErrorExt { get; set; } = default!;

//    [JsonProperty("message")]
//    public string Message { get; set; } = default!;
//}

//public class PaymentDataQueryRs
//{
//    [JsonProperty("id")]
//    public Guid Id { get; set; }

//    [JsonProperty("dateAdded")]
//    public DateTime DateAdded { get; set; }

//    [JsonProperty("dateUpdated")]
//    public DateTime DateUpdated { get; set; }

//    [JsonProperty("typeOperation")]
//    public string TypeOperation { get; set; } = default!;

//    [JsonProperty("status")]
//    public string Status { get; set; } = default!;

//    [JsonProperty("idTransactionMerchant")]
//    public string IdTransactionMerchant { get; set; } = default!;

//    [JsonProperty("amountInitial")]
//    public decimal AmountInitial { get; set; }

//    [JsonProperty("amountRandomized")]
//    public decimal AmountRandomized { get; set; }

//    [JsonProperty("amount")]
//    public decimal Amount { get; set; }

//    [JsonProperty("amountComission")]
//    public decimal AmountComission { get; set; }

//    [JsonProperty("currency")]
//    public string Currency { get; set; } = default!;

//    [JsonProperty("amountInCurrencyBalance")]
//    public decimal AmountInCurrencyBalance { get; set; }

//    [JsonProperty("amountComissionInCurrencyBalance")]
//    public decimal AmountComissionInCurrencyBalance { get; set; }

//    [JsonProperty("exchangeRate")]
//    public decimal ExchangeRate { get; set; }

//    [JsonProperty("paymentDetailsData")]
//    public PaymentDetailsDataQueryRs PaymentDetailsData { get; set; } = default!;
//}

//public class PaymentDetailsDataQueryRs
//{
//    [JsonProperty("nameMediator")]
//    public string NameMediator { get; set; } = default!;

//    [JsonProperty("paymentMethod")]
//    public string PaymentMethod { get; set; } = default!;

//    [JsonProperty("bankName")]
//    public string BankName { get; set; } = default!;

//    [JsonProperty("number")]
//    public string Number { get; set; } = default!;

//    [JsonProperty("numberAdditional")]
//    public string NumberAdditional { get; set; } = default!;

//    [JsonProperty("qRcode")]
//    public string QRCode { get; set; } = default!;
//}