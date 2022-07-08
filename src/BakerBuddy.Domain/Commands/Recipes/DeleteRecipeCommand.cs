using MediatR;

namespace BakerBuddy.Domain.Commands.Recipes;

public class DeleteRecipeCommand : IRequest
{
    public int RecipeId { get; }

    public DeleteRecipeCommand(int recipeId)
    {
        RecipeId = recipeId;
    }
}