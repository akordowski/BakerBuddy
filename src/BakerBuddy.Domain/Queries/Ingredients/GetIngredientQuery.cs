using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Queries.Ingredients;

public class GetIngredientQuery : IRequest<IngredientDetailDto?>
{
    public int IngredientId { get; }

    public GetIngredientQuery(int ingredientId)
    {
        IngredientId = ingredientId;
    }
}