using MediatR;
using Ultra.Core.Mq.Messages;

namespace Ultra.Infrastructure.Mq.Messages;

public interface IMediatrEvent : IEvent, INotification;
