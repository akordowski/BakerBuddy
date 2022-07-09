using MediatR;

namespace BakerBuddy.Application.Handler.Commands;

public abstract class CommandHandler<TRequest> : IRequestHandler<TRequest>
    where TRequest : IRequest
{
    async Task<Unit> IRequestHandler<TRequest, Unit>.Handle(TRequest request, CancellationToken cancellationToken)
    {
        await Handle(request, cancellationToken).ConfigureAwait(false);
        return Unit.Value;
    }

    /// <summary>
    /// Override in a derived class for the handler logic
    /// </summary>
    /// <param name="request">Request</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Response</returns>
#pragma warning disable VSTHRD200 // Use "Async" suffix for async methods
    public abstract Task Handle(TRequest request, CancellationToken cancellationToken);
#pragma warning restore VSTHRD200 // Use "Async" suffix for async methods
}