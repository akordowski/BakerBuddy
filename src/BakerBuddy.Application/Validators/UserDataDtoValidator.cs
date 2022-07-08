using BakerBuddy.Domain.Dto;
using FluentValidation;

namespace BakerBuddy.Application.Validators;

public class UserDataDtoValidator : AbstractValidator<UserDataDto>
{
    public UserDataDtoValidator()
    {
        RuleFor(o => o.UserName)
            .NotNull()
            .NotEmpty();

        RuleFor(o => o.Password)
            .NotNull()
            .NotEmpty();

        RuleFor(o => o.FirstName)
            .NotNull()
            .NotEmpty();

        RuleFor(o => o.LastName)
            .NotNull()
            .NotEmpty();

        RuleFor(o => o.Email)
            .NotNull()
            .NotEmpty()
            .EmailAddress();
    }
}