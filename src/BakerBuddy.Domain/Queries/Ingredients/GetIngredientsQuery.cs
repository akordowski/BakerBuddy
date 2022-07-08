using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Queries.Ingredients;

public class GetIngredientsQuery : IRequest<IEnumerable<IngredientInfoDto>?>
{
    public int RecipeId { get; }

    public GetIngredientsQuery(int recipeId)
    {
        RecipeId = recipeId;
    }
}