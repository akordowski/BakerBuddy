using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.Recipes;

public class DeleteRecipeCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public DeleteRecipeCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Delete_Recipe()
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