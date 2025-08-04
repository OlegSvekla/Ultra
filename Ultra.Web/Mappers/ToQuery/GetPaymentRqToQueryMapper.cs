using Ultra.Contracts.Queries;
using Ultra.Core.Mappers;
using Ultra.Web.Rqs;

namespace Ultra.Web.Mappers.ToQuery;

public class GetPaymentRqToQueryMapper
: IMapper<GetPaymentRq, GetPaymentQuery>
{
    public GetPaymentQuery Map(
        GetPaymentRq input)
        => new GetPaymentQuery
        (
            input.ClientID,
            input.ClientIP,
            input.ClientDateCreated,
            input.PaymentMethod,
            input.IdTransactionMerchant,
            input.Amount,
            new IntegrationMerchantQuery(input.IntegrationMerhcnatRq.WebHook)
        );
}
