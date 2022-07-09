using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.Ingredients;

public class DeleteIngredientCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public DeleteIngredientCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Delete_Ingredient()
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