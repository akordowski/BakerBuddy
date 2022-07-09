using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Queries.Ingredients;
using MediatR;

namespace BakerBuddy.Application.Handler.Queries.Ingredients;

public class GetIngredientQueryHandler : IRequestHandler<GetIngredientQuery, IngredientDto?>
{
    public Task<IngredientDto?> Handle(
        GetIngredientQuery request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}