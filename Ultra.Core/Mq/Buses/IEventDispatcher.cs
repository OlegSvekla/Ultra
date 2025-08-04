using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Buses;

public interface IEventDispatcher
{
    ValueTask DispatchAsync(IEvent @event, CancellationToken ct);
}
