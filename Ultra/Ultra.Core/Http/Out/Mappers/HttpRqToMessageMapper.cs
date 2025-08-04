using Ultra.Core.Http.Out.Helpers;
using Ultra.Core.Http.Out.Models;
using Ultra.Core.Mappers;

namespace Ultra.Core.Http.Out.Mappers;

public interface IHttpRqToMessageMapper
    : IMapper<HttpRq, HttpRequestMessage>;

public class HttpRqToMessageMapper
    : IHttpRqToMessageMapper
{
    public HttpRequestMessage Map(HttpRq input)
    {
        var uri = input.Uri.BuildUriWithQueries(input.Queries);

        var rq = new HttpRequestMessage
        {
            RequestUri = uri,
            Method = input.Method,
        };
        rq.Headers.AddRange(input.Headers);

        return rq;
    }
}
