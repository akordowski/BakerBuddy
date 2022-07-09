using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Queries.Ingredients;

public class GetIngredientQueryHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public GetIngredientQueryHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Get_Ingredient()
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