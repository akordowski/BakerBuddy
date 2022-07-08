using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Queries.Ingredients;
using MediatR;

namespace BakerBuddy.Application.Handler.Queries.Ingredients;

public class GetIngredientsQueryHandler : IRequestHandler<GetIngredientsQuery, IEnumerable<IngredientInfoDto>>
{
    public Task<IEnumerable<IngredientInfoDto>> Handle(
        GetIngredientsQuery request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}