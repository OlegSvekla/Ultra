using MediatR;
using Ultra.Core.Helpers;
using Ultra.Core.Mq.Buses;
using Ultra.Core.Mq.Exceptions;
using Ultra.Core.Mq.Messages;
using Ultra.Infrastructure.Mq.Messages;

namespace Ultra.Infrastructure.Mq;

public interface IMediatrLocalMessageBus : ILocalMessageBus;

public class MediatrLocalMessageBus(
    IMediator mediator
    ) : IMediatrLocalMessageBus
{
    private const string NotRegisteredHandlerExceptionRegex
        = @"No service for type '.*' has been registered\.";

    public async ValueTask DispatchAsync(ICommand command, CancellationToken ct)
    {
        try
        {
            var mediatrCommand = (IMediatrCommand)command;
            await mediator.Send(mediatrCommand, ct);
        }
        catch (InvalidOperationException ex)
        when (ex.Message.MatchRegex(NotRegisteredHandlerExceptionRegex))
        {
            throw new PoisonCommandException(command, ex);
        }
    }

    public async ValueTask DispatchAsync(IEvent @event, CancellationToken ct)
    {
        try
        {
            var mediatrEvent = (IMediatrEvent)@event;
            await mediator.Publish(mediatrEvent, ct);
        }
        catch (InvalidOperationException ex)
        when (ex.Message.MatchRegex(NotRegisteredHandlerExceptionRegex))
        {
            throw new PoisonEventException(@event, ex);
        }
    }

    public async ValueTask<TResponse> DispatchAsync<TResponse>(
        IQuery<TResponse> query, CancellationToken ct)
    {
        try
        {
            var mediatrQuery = (IMediatrQuery<TResponse>)query;
            var result = await mediator.Send(mediatrQuery, ct);
            return (TResponse)result;
        }
        catch (InvalidOperationException ex)
        when (ex.Message.MatchRegex(NotRegisteredHandlerExceptionRegex))
        {
            throw new PoisonQueryException(query, ex);
        }
    }
}
