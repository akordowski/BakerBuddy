using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Recipes;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Recipes;

public class CreateRecipeCommandHandler : CommandHandler<CreateRecipeCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly ILogger _logger;

    public CreateRecipeCommandHandler(
        IBakerBuddyDbContext dbContext,
        ILogger logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public override Task Handle(
        CreateRecipeCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}