using CleanArc.Domain.Core.Bus;
using CleanArc.Domain.Core.Commands;
using MediatR;

namespace CleanArc.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }


        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }



    }
}
