using AutoMapper;
using BakerBuddy.Data;
using BakerBuddy.Data.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Moq;
using Serilog;

namespace BakerBuddy.Application.UnitTests.Fixtures;

public class HandlerFixture : IDisposable
{
    public Faker Faker { get; } = new("de");

    public BakerBuddyDbContext DbContext { get; }

    public Mock<IMapper> MapperMock { get; } = new();
    public Mock<ILogger> LoggerMock { get; } = new();

    private int _fakerIngredientId = 1;
    private int _fakerRecipeId = 1;
    private int _fakerUserId = 1;

    public HandlerFixture()
    {
        var databaseName = Guid.NewGuid().ToString();

        var options = new DbContextOptionsBuilder<BakerBuddyDbContext>()
            .UseInMemoryDatabase(databaseName)
            .Options;

        DbContext = new(options);
    }

    public Faker<IngredientEntity> GetIngredientFaker(int? recipeId = null)
    {
        return new Faker<IngredientEntity>()
            .RuleFor(e => e.IngredientId, (f, e) => recipeId == null ? 0 : _fakerIngredientId++)
            .RuleFor(e => e.RecipeId, (f, e) => recipeId ?? f.Random.Int())
            .RuleFor(e => e.Name, (f, e) => f.Random.Words())
            .RuleFor(e => e.Amount, (f, e) => f.Random.UInt(1000));
    }

    public Faker<RecipeEntity> GetRecipeFaker(int? userId = null)
    {
        return new Faker<RecipeEntity>()
            .RuleFor(e => e.RecipeId, (f, e) => _fakerRecipeId++)
            .RuleFor(e => e.UserId, (f, e) => userId ?? f.Random.Int())
            .RuleFor(e => e.Name, (f, e) => f.Random.Words())
            .RuleFor(e => e.Description, (f, e) => f.Lorem.Sentence())
            .RuleFor(e => e.Instructions, (f, e) => f.Lorem.Sentences())
            .RuleFor(e => e.Likes, (f, e) => f.Random.UInt());
    }

    public Faker<UserEntity> GetUserFaker()
    {
        return new Faker<UserEntity>()
            .RuleFor(e => e.UserId, (f, e) => _fakerUserId++)
            .RuleFor(e => e.UserName, (f, e) => f.Internet.UserName())
            .RuleFor(e => e.Password, (f, e) => f.Internet.Password())
            .RuleFor(e => e.FirstName, (f, e) => f.Name.FirstName())
            .RuleFor(e => e.LastName, (f, e) => f.Name.LastName())
            .RuleFor(e => e.Email, (f, e) => f.Internet.Email());
    }

    public void ResetDb()
    {
        DbContext.Ingredient.RemoveRange(DbContext.Ingredient);
        DbContext.Recipe.RemoveRange(DbContext.Recipe);
        DbContext.User.RemoveRange(DbContext.User);
    }

    public void ResetMocks()
    {
        MapperMock.Reset();
        LoggerMock.Reset();
    }

    public void Dispose()
    {
        DbContext.Dispose();
    }
}