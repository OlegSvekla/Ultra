using Ultra.Core.Mq.Messages;
using MediatR;

namespace Ultra.Infrastructure.Mq.Messages;

public interface IMediatrQuery<out TResponse>
    : IQuery<TResponse>,
    IRequest<object>;
