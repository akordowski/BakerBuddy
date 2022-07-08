using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Commands.Recipes;

public class CreateRecipeCommand : IRequest
{
    public RecipeDataDto Recipe { get; }

    public CreateRecipeCommand(RecipeDataDto recipe)
    {
        Recipe = recipe;
    }
}