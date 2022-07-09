using BakerBuddy.Application.Handler.Commands.Ingredients;
using BakerBuddy.Application.UnitTests.Fixtures;
using BakerBuddy.Data.Entities;
using BakerBuddy.Domain.Commands.Ingredients;
using BakerBuddy.Domain.Dto;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;

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
        var ingredient = _fixture.GetIngredientFaker(1).Generate();

        _fixture.MapperMock
            .Setup(m => m.Map<IngredientEntity>(It.IsAny<object>()))
            .Returns(ingredient);

        var ingredientDto = new IngredientDataDto();
        var command = new CreateIngredientCommand(ingredientDto);
        var handler = new CreateIngredientCommandHandler(
            _fixture.DbContext,
            _fixture.MapperMock.Object,
            _fixture.LoggerMock.Object);

        // Act
        await handler.Handle(command, default);

        // Assert
        var result = await _fixture.DbContext.Ingredient
            .Where(e => e.RecipeId == ingredient.RecipeId)
            .SingleAsync();

        result.Should().NotBeNull();

        _fixture.MapperMock.Verify(m => m.Map<IngredientEntity>(ingredientDto), Times.Once);
        _fixture.MapperMock.VerifyNoOtherCalls();
    }

    public void Dispose()
    {
        _fixture.ResetDb();
        _fixture.ResetMocks();
    }
}