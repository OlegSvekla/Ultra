using Ultra.Core.Exceptions;
using Ultra.Core.Helpers;
using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Exceptions;

public class PoisonEventException(
    IEvent @event,
    Exception? innerEx = null
    ) : DomainException(
        message: $"Poison event '{@event.GetType().GetFriendlyShortName()}' has been found",
        innerEx: innerEx)
{
    public override int Code => (int)ExCodes.PoisonEvent;
}
