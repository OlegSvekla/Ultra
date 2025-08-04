using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Handlers;

public interface ICommandHandler<in TCommand>
    where TCommand : ICommand
{
    ValueTask HandleAsync(TCommand command, CancellationToken ct);
}
