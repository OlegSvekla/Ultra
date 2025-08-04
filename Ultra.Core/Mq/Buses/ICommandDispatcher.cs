using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Buses;

public interface ICommandDispatcher
{
    ValueTask DispatchAsync(ICommand command, CancellationToken ct);
}
