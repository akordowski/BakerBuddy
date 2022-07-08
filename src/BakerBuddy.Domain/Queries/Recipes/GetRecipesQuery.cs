using BakerBuddy.Domain.Dto;
using MediatR;

namespace BakerBuddy.Domain.Queries.Recipes;

public class GetRecipesQuery : IRequest<IEnumerable<RecipeInfoDto>?>
{
    public int UserId { get; }

    public GetRecipesQuery(int userId)
    {
        UserId = userId;
    }
}