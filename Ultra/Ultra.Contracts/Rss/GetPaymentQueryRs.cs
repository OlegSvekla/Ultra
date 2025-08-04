namespace Ultra.Contracts.Rss;

public record GetPaymentQueryRs(
    ResultQueryRs Result,
    PaymentDataQueryRs Data,
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