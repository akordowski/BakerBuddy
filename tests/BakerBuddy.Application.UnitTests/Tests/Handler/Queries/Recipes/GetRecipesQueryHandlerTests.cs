using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Queries.Recipes;

public class GetRecipesQueryHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public GetRecipesQueryHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Get_Recipes()
    {
        // Arrange

        // Act

        // Assert
    }

    public void Dispose()
    {
    }
}