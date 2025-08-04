using MediatR;
using Ultra.Core.Mq.Handlers;
using Ultra.Infrastructure.Mq.Messages;

namespace Ultra.Infrastructure.Mq.Handlers;

public interface IMediatrEventHandler<TEvent>
    : IEventHandler<TEvent>,
    INotificationHandler<TEvent>
    where TEvent : IMediatrEvent;

public abstract class MediatrEventHandler<TEvent>
    : IMediatrEventHandler<TEvent>
    where TEvent : IMediatrEvent
{
    public Task Handle(
        TEvent notification,
        CancellationToken cancellationToken)
        => HandleAsync(notification, cancellationToken).AsTask();

    public abstract ValueTask HandleAsync(
        TEvent @event,
        CancellationToken ct);
}
