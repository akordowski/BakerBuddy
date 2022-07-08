using MediatR;

namespace BakerBuddy.Domain.Commands.Ingredients;

public class DeleteIngredientCommand : IRequest
{
    public int IngredientId { get; }

    public DeleteIngredientCommand(int ingredientId)
    {
        IngredientId = ingredientId;
    }
}