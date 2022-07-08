using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Commands.Users;

public class RegisterUserCommand : IRequest
{
    public UserDataDto UserData { get; }

    public RegisterUserCommand(UserDataDto userData)
    {
        UserData = userData;
    }
}