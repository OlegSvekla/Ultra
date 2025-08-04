using Ultra.Core.Exceptions;
using Ultra.Core.Helpers;
using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Exceptions;

public class PoisonCommandException(
    ICommand command,
    Exception? innerEx = null
    ) : DomainException(
        message: $"Poison command '{command.GetType().GetFriendlyShortName()}' has been found",
        innerEx: innerEx)
{
    public override int Code => (int)ExCodes.PoisonCommand;
}
