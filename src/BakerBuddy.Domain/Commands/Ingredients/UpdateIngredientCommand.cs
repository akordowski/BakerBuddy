using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Commands.Ingredients;

public class UpdateIngredientCommand : IRequest
{
    public IngredientDto Ingredient { get; }

    public UpdateIngredientCommand(IngredientDto ingredient)
    {
        Ingredient = ingredient;
    }
}