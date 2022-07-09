using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Queries.Recipes;
using MediatR;

namespace BakerBuddy.Application.Handler.Queries.Recipes;

public class GetRecipeQueryHandler : IRequestHandler<GetRecipeQuery, RecipeDto?>
{
    public Task<RecipeDto?> Handle(
        GetRecipeQuery request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}