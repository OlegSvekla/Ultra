namespace Ultra.Core.Mq.Buses;

public interface IDistributedMessageBus
    : ICommandDispatcher,
    IEventDispatcher,
    IQueryDispatcher
{
}
