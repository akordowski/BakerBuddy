using AutoMapper;
using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Recipes;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Recipes;

public class UpdateRecipeCommandHandler : CommandHandler<UpdateRecipeCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public UpdateRecipeCommandHandler(
        IBakerBuddyDbContext dbContext,
        IMapper mapper,
        ILogger logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }

    public override Task Handle(
        UpdateRecipeCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}