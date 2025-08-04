using Ultra.Core.Exceptions;
using Ultra.Core.Helpers;
using Ultra.Core.Mq.Messages;

namespace Ultra.Core.Mq.Exceptions;

public class PoisonQueryException(
    IQuery query,
    Exception? innerEx = null
    ) : DomainException(
        message: $"Poison query '{query.GetType().GetFriendlyShortName()}' has been found",
        innerEx: innerEx)
{
    public override int Code => (int)ExCodes.PoisonQuery;
}
