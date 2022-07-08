using BakerBuddy.Application.UnitTests.Fixtures;

namespace BakerBuddy.Application.UnitTests.Tests.Handler.Commands.User;

public class RegisterUserCommandHandlerTests : IDisposable
{
    private readonly HandlerFixture _fixture;

    public RegisterUserCommandHandlerTests(HandlerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Should_Register_User()
    {
        // Arrange

        // Act

        // Assert
    }

    public void Dispose()
    {
    }
}