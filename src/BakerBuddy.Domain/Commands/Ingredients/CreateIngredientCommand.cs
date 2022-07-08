using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Commands.Ingredients;

public class CreateIngredientCommand : IRequest
{
    public IngredientDataDto Ingredient { get; }

    public CreateIngredientCommand(IngredientDataDto ingredient)
    {
        Ingredient = ingredient;
    }
}