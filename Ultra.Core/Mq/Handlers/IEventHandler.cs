using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Handlers;

public interface IEventHandler<in TEvent>
    where TEvent : IEvent
{
    ValueTask HandleAsync(TEvent @event, CancellationToken ct);
}