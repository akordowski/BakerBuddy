using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Queries.Recipes;

public class GetRecipeQuery : IRequest<RecipeDto?>
{
    public int RecipeId { get; }

    public GetRecipeQuery(int recipeId)
    {
        RecipeId = recipeId;
    }
}