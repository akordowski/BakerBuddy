using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.Recipes;

public class CreateRecipeCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public CreateRecipeCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Create_Recipe()
    {
        // Arrange

        // Act

        // Assert
    }

    public void Dispose()
    {
    }
}