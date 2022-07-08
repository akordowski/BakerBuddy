using AutoMapper;
using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Ingredients;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Ingredients;

public class UpdateIngredientCommandHandler : CommandHandler<UpdateIngredientCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public UpdateIngredientCommandHandler(
        IBakerBuddyDbContext dbContext,
        IMapper mapper,
        ILogger logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }

    public override Task Handle(
        UpdateIngredientCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}