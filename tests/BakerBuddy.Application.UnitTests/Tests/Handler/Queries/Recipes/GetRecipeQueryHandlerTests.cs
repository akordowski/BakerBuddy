using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Queries.Recipes;

public class GetRecipeQueryHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public GetRecipeQueryHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Get_Recipe()
    {
        // Arrange

        // Act

        // Assert
    }

    public void Dispose()
    {
        _fixture.ResetDb();
        _fixture.ResetMocks();
    }
}