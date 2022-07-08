using AutoMapper;
using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Recipes;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Recipes;

public class CreateRecipeCommandHandler : CommandHandler<CreateRecipeCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public CreateRecipeCommandHandler(
        IBakerBuddyDbContext dbContext,
        IMapper mapper,
        ILogger logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }

    public override Task Handle(
        CreateRecipeCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}