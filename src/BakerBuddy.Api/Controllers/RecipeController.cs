using BakerBuddy.Api.Helper;
using BakerBuddy.Domain.Commands.Recipes;
using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Queries.Ingredients;
using BakerBuddy.Domain.Queries.Recipes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BakerBuddy.Api.Controllers;

public class RecipeController : ControllerBase
{
    private readonly ISender _sender;

    public RecipeController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost(ApiRoutes.Recipe.Post)]
    [SwaggerOperation("Creates a new recipe.")]
    public async Task<ActionResult> CreateRecipeAsync(CancellationToken cancellationToken)
    {
        var command = new CreateRecipeCommand();
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }

    [HttpGet(ApiRoutes.Recipe.Get)]
    [SwaggerOperation("Get a recipe.")]
    public async Task<ActionResult<RecipeDetailDto>> GetRecipeAsync(
        [FromRoute(Name = "id")] int recipeId,
        CancellationToken cancellationToken)
    {
        var query = new GetRecipeQuery(recipeId);
        var recipe = await _sender.Send(query, cancellationToken);

        if (recipe is null)
        {
            return NotFound();
        }

        return Ok(recipe);
    }

    [HttpGet(ApiRoutes.Recipe.Ingredient.GetAll)]
    [SwaggerOperation("Get a recipe ngredients.")]
    public async Task<ActionResult<RecipeDetailDto>> GetRecipeIngredientsAsync(
        [FromRoute(Name = "id")] int recipeId,
        CancellationToken cancellationToken)
    {
        var query = new GetIngredientsQuery(recipeId);
        var ingredients = await _sender.Send(query, cancellationToken);

        if (ingredients is null)
        {
            return NotFound();
        }

        return Ok(ingredients);
    }

    [HttpPut(ApiRoutes.Recipe.Put)]
    [SwaggerOperation("Updates a recipe.")]
    public async Task<ActionResult> UpdateRecipeAsync(CancellationToken cancellationToken)
    {
        var command = new UpdateRecipeCommand();
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }

    [HttpDelete(ApiRoutes.Recipe.Delete)]
    [SwaggerOperation("Deletes a recipe.")]
    public async Task<ActionResult> DeleteRecipeAsync(
        [FromRoute(Name = "id")] int recipeId,
        CancellationToken cancellationToken)
    {
        var command = new DeleteRecipeCommand(recipeId);
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }
}