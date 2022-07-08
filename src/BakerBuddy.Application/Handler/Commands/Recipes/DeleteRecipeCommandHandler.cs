using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Recipes;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Recipes;

public class DeleteRecipeCommandHandler : CommandHandler<DeleteRecipeCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly ILogger _logger;

    public DeleteRecipeCommandHandler(
        IBakerBuddyDbContext dbContext,
        ILogger logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public override Task Handle(
        DeleteRecipeCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}