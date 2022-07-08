using BakerBuddy.Data.Entities;
using Bogus;

namespace BakerBuddy.Application.UnitTests.Fixtures;

public class HandlerFixture
{
    public Faker Faker { get; } = new("de");

    private int _fakerIngredientId = 1;
    private int _fakerRecipeId = 1;
    private int _fakerUserId = 1;

    public HandlerFixture()
    {
    }

    public Faker<IngredientEntity> GetIngredientFaker()
    {
        return new Faker<IngredientEntity>()
            .RuleFor(e => e.IngredientId, (f, e) => _fakerIngredientId++)
            .RuleFor(e => e.Name, (f, e) => f.Random.Words())
            .RuleFor(e => e.Amount, (f, e) => f.Random.UInt(1000));
    }

    public Faker<RecipeEntity> GetRecipeFaker()
    {
        return new Faker<RecipeEntity>()
            .RuleFor(e => e.RecipeId, (f, e) => _fakerRecipeId++)
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
}