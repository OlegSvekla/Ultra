using Ultra.Contracts.Rss;
using Ultra.Infrastructure.Mq.Handlers;

namespace Ultra.Contracts.Queries;

public record GetPaymentQuery(
    ResultQuery Result,
    PaymentDataQuery Data,
    int TotalNumberRecords
) : IMediatrQuery<GetPaymentQueryRs>;

public record ResultQuery(
    string Status,
    string XRequestId,
    string CodeError,
    string CodeErrorExt,
    string Message
);

public record PaymentDataQuery(
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
    PaymentDetailsDataQuery PaymentDetailsData
);

public record PaymentDetailsDataQuery(
    string NameMediator,
    string PaymentMethod,
    string BankName,
    string Number,
    string NumberAdditional,
    string QRCode
);

