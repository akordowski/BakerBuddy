using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Queries.Ingredients;

public class GetIngredientQuery : IRequest<IngredientDto?>
{
    public int IngredientId { get; }

    public GetIngredientQuery(int ingredientId)
    {
        IngredientId = ingredientId;
    }
}