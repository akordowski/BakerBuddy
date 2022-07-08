using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Ingredients;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Ingredients;

public class UpdateIngredientCommandHandler : CommandHandler<UpdateIngredientCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly ILogger _logger;

    public UpdateIngredientCommandHandler(
        IBakerBuddyDbContext dbContext,
        ILogger logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public override Task Handle(
        UpdateIngredientCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}