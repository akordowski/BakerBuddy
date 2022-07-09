using AutoMapper;
using BakerBuddy.Data;
using BakerBuddy.Data.Entities;
using BakerBuddy.Domain.Commands.Ingredients;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.Ingredients;

public class CreateIngredientCommandHandler : CommandHandler<CreateIngredientCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public CreateIngredientCommandHandler(
        IBakerBuddyDbContext dbContext,
        IMapper mapper,
        ILogger logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }

    public override async Task Handle(
        CreateIngredientCommand request,
        CancellationToken cancellationToken)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        var ingredient = _mapper.Map<IngredientEntity>(request.Ingredient);

        await _dbContext.Ingredient.AddAsync(ingredient, cancellationToken).ConfigureAwait(false);
        await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }
}