using MediatR;
using Ultra.Core.Mq.Messages;

namespace Ultra.Infrastructure.Mq.Handlers;

public interface IMediatrQuery<out TResponse>
    : IQuery<TResponse>,
    IRequest<object>;
