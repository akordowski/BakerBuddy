using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.Ingredients;

public class UpdateIngredientCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public UpdateIngredientCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Update_Ingredient()
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