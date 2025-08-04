using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Buses;

public interface IQueryDispatcher
{
    ValueTask<TResponse> DispatchAsync<TResponse>(
        IQuery<TResponse> query, CancellationToken ct);
}
