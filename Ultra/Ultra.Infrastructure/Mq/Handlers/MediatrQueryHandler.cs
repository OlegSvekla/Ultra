using MediatR;
using Ultra.Core.Mq.Messages;

namespace Ultra.Infrastructure.Mq.Handlers;

public interface IMediatrQueryHandler<TQuery, TResponse>
    : IQueryHandler<TQuery, TResponse>,
    IRequestHandler<TQuery, object>
    where TQuery : IMediatrQuery<TResponse>, IQuery<TResponse>, IRequest<object>;

public abstract class MediatrQueryHandler<TQuery, TResponse>
    : IMediatrQueryHandler<TQuery, TResponse>
    where TQuery : IMediatrQuery<TResponse>, IQuery<TResponse>, IRequest<object>
{
    public async Task<object> Handle(
        TQuery request,
        CancellationToken cancellationToken)
        => (await HandleAsync(request, cancellationToken))!;

    public abstract ValueTask<TResponse> HandleAsync(
        TQuery query,
        CancellationToken ct);
}
