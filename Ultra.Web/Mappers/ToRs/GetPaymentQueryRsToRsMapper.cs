using Ultra.Core.Mappers;
using Ultra.Contracts.Rss;
using Ultra.Web.Rss;

namespace Ultra.Web.Mappers.ToRs;

public class GetPaymentQueryRsToRsMapper
    : IMapper<GetPaymentQueryRs, GetPaymentRs>
{
    public GetPaymentRs Map(GetPaymentQueryRs input)
        => new GetPaymentRs(
            new ResultRs(
                input.Result.Status,
                input.Result.XRequestId,
                input.Result.CodeError,
                input.Result.CodeErrorExt,
                input.Result.Message
            ),
            input.Data is not null
                ? new PaymentDataRs(
                    input.Data.Id,
                    input.Data.DateAdded,
                    input.Data.DateUpdated,
                    input.Data.TypeOperation,
                    input.Data.Status,
                    input.Data.IdTransactionMerchant,
                    input.Data.AmountInitial,
                    input.Data.AmountRandomized,
                    input.Data.Amount,
                    input.Data.AmountComission,
                    input.Data.Currency,
                    input.Data.AmountInCurrencyBalance,
                    input.Data.AmountComissionInCurrencyBalance,
                    input.Data.ExchangeRate,
                    new PaymentDetailsDataRs(
                        input.Data.PaymentDetailsData.NameMediator,
                        input.Data.PaymentDetailsData.PaymentMethod,
                        input.Data.PaymentDetailsData.BankName,
                        input.Data.PaymentDetailsData.Number,
                        input.Data.PaymentDetailsData.NumberAdditional,
                        input.Data.PaymentDetailsData.QRCode
                    )
                )
                : null,
            input.TotalNumberRecords
        );

}


