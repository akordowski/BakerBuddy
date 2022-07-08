using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.Ingredients;

[Collection(Collections.HandlerCollection)]
public class CreateIngredientCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public CreateIngredientCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Create_Ingredient()
    {
        // Arrange

        // Act

        // Assert
    }

    public void Dispose()
    {
    }
}