using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Commands.Recipes;

public class UpdateRecipeCommand : IRequest
{
    public RecipeDto Recipe { get; }

    public UpdateRecipeCommand(RecipeDto recipe)
    {
        Recipe = recipe;
    }
}