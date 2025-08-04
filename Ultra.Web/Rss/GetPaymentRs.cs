namespace Ultra.Web.Rss;

public record GetPaymentRs(
    ResultRs Result,
    PaymentDataRs Data,
    int TotalNumberRecords
);

public record ResultRs(
    string Status,
    string XRequestId,
    string CodeError,
    string CodeErrorExt,
    string Message
);

public record PaymentDataRs(
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
    PaymentDetailsDataRs PaymentDetailsData
);

public record PaymentDetailsDataRs(
    string NameMediator,
    string PaymentMethod,
    string BankName,
    string Number,
    string NumberAdditional,
    string QRCode
);
