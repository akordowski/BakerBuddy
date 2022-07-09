using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Ingredients;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Ingredients;

public class DeleteIngredientCommandHandler : CommandHandler<DeleteIngredientCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly ILogger _logger;

    public DeleteIngredientCommandHandler(
        IBakerBuddyDbContext dbContext,
        ILogger logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public override Task Handle(
        DeleteIngredientCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}