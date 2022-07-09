using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.Recipes;

public class UpdateRecipeCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public UpdateRecipeCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Update_Recipe()
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