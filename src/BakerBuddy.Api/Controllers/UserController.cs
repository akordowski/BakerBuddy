using BakerBuddy.Api.Helper;
using BakerBuddy.Domain.Commands.User;
using BakerBuddy.Domain.Dto;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BakerBuddy.Api.Controllers;

[ApiController]
[AllowAnonymous]
[SwaggerResponse(StatusCodes.Status200OK, StatusDescriptions.Status200OK)]
[SwaggerResponse(StatusCodes.Status500InternalServerError, StatusDescriptions.Status500InternalServerError)]
public class UserController : ControllerBase
{
    private readonly ISender _sender;

    public UserController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost(ApiRoutes.User.Register.Post)]
    [SwaggerOperation("Register a new user.")]
    [SwaggerResponse(StatusCodes.Status204NoContent, StatusDescriptions.Status204NoContent)]
    [SwaggerResponse(StatusCodes.Status400BadRequest, StatusDescriptions.Status400BadRequest)]
    public async Task<ActionResult> RegisterUserAsync(
        [FromBody] UserDataDto userData,
        CancellationToken cancellationToken)
    {
        var command = new RegisterUserCommand(userData);
        await _sender.Send(command, cancellationToken);

        return NoContent();
    }
}