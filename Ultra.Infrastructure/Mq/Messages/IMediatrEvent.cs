using Ultra.Core.Mq.Messages;
using MediatR;

namespace Ultra.Infrastructure.Mq.Messages;

public interface IMediatrEvent : IEvent, INotification;
