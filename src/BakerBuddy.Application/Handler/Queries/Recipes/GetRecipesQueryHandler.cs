using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Queries.Recipes;
using MediatR;

namespace BakerBuddy.Application.Handler.Queries.Recipes;

public class GetRecipesQueryHandler : IRequestHandler<GetRecipesQuery, IEnumerable<RecipeDto>?>
{
    public Task<IEnumerable<RecipeDto>?> Handle(
        GetRecipesQuery request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}