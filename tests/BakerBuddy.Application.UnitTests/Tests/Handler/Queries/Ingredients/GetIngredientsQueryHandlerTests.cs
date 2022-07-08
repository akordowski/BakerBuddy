using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Queries.Ingredients;

public class GetIngredientsQueryHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public GetIngredientsQueryHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Get_Ingredients()
    {
        // Arrange

        // Act

        // Assert
    }

    public void Dispose()
    {
    }
}