using BakerBuddy.Domain.Dto;
using FluentValidation;

namespace BakerBuddy.Application.Validators;

public class IngredientDataDtoValidator : AbstractValidator<IngredientDataDto>
{
    public IngredientDataDtoValidator()
    {
        RuleFor(o => o.Name)
            .NotNull()
            .NotEmpty();

        RuleFor(o => (int)o.Amount)
            .GreaterThan(0);
    }
}