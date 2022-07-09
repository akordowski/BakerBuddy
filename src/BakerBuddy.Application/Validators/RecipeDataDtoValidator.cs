using BakerBuddy.Domain.Dto;
using FluentValidation;

namespace BakerBuddy.Application.Validators;

public class RecipeDataDtoValidator : AbstractValidator<RecipeDataDto>
{
    public RecipeDataDtoValidator()
    {
        RuleFor(o => o.Name)
            .NotNull()
            .NotEmpty();

        RuleFor(o => o.Description)
            .NotNull()
            .NotEmpty();

        RuleFor(o => o.Instructions)
            .NotNull()
            .NotEmpty();
    }
}