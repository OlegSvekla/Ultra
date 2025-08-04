using MediatR;
using Ultra.Core.Mq.Messages;

namespace Ultra.Infrastructure.Mq.Messages;

public interface IMediatrCommand : ICommand, IRequest;

public interface IMediatrCreateCommand : IMediatrCommand, ICreateCommand;
