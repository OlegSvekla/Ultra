using Ultra.Contracts.Queries;
using Ultra.Contracts.Rss;
using Ultra.Core.Mappers;
using Ultra.Web.Mappers.ToQuery;
using Ultra.Web.Mappers.ToRs;
using Ultra.Web.Rqs;
using Ultra.Web.Rss;

namespace Ultra.Web.Mappers;

public static class Bootstrap
{
    public static IServiceCollection AddWebMappers(this IServiceCollection services)
    {
        services.AddScoped<IMapper<GetPaymentRq, GetPaymentQuery>, GetPaymentRqToQueryMapper>();
        services.AddScoped<IMapper<GetPaymentQueryRs, GetPaymentRs>, GetPaymentQueryRsToRsMapper>();

        return services;
    }
}