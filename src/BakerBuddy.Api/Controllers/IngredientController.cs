using BakerBuddy.Api.Helper;
using BakerBuddy.Domain.Commands.Ingredients;
using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Queries.Ingredients;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BakerBuddy.Api.Controllers;

[ApiController]
[AllowAnonymous]
[SwaggerResponse(StatusCodes.Status200OK, StatusDescriptions.Status200OK)]
[SwaggerResponse(StatusCodes.Status500InternalServerError, StatusDescriptions.Status500InternalServerError)]
public class IngredientController : ControllerBase
{
    private readonly ISender _sender;

    public IngredientController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost(ApiRoutes.Ingredient.Post)]
    [SwaggerOperation("Creates a new ingredient.")]
    public async Task<ActionResult> CreateIngredientAsync(
        [FromBody] IngredientDataDto ingredient,
        CancellationToken cancellationToken)
    {
        var command = new CreateIngredientCommand(ingredient);
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }

    [HttpGet(ApiRoutes.Ingredient.Get)]
    [SwaggerOperation("Get a ingredient.")]
    public async Task<ActionResult> GetIngredientAsync(
        [FromRoute(Name = "id")] int ingredientId,
        CancellationToken cancellationToken)
    {
        var query = new GetIngredientQuery(ingredientId);
        var ingredient = await _sender.Send(query, cancellationToken);

        if (ingredient is null)
        {
            return NotFound();
        }

        return Ok(ingredient);
    }

    [HttpPut(ApiRoutes.Ingredient.Put)]
    [SwaggerOperation("Updates a ingredient.")]
    public async Task<ActionResult> UpdateIngredientAsync(
        [FromBody] IngredientDto ingredient,
        CancellationToken cancellationToken)
    {
        var command = new UpdateIngredientCommand(ingredient);
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }

    [HttpDelete(ApiRoutes.Ingredient.Delete)]
    [SwaggerOperation("Deletes a ingredient.")]
    public async Task<ActionResult> DeleteIngredientAsync(
        [FromRoute(Name = "id")] int ingredientId,
        CancellationToken cancellationToken)
    {
        var command = new DeleteIngredientCommand(ingredientId);
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }
}