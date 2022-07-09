using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Queries.Recipes;

public class GetRecipesQuery : IRequest<IEnumerable<RecipeDto>?>
{
    public int UserId { get; }

    public GetRecipesQuery(int userId)
    {
        UserId = userId;
    }
}