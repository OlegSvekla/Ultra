using Ultra.Core.Mq.Messages;

namespace Ultra.Infrastructure.Mq.Handlers;

public interface IQueryHandler<in TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
    ValueTask<TResponse> HandleAsync(TQuery query, CancellationToken ct);
}
