using Ultra.Core.Mq.Messages;
using MediatR;

namespace Ultra.Infrastructure.Mq.Messages;

public interface IMediatrCommand : ICommand, IRequest;

public interface IMediatrCreateCommand : IMediatrCommand, ICreateCommand;
