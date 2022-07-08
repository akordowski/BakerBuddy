using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Ingredients;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Ingredients;

public class CreateIngredientCommandHandler : CommandHandler<CreateIngredientCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly ILogger _logger;

    public CreateIngredientCommandHandler(
        IBakerBuddyDbContext dbContext,
        ILogger logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public override Task Handle(
        CreateIngredientCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}