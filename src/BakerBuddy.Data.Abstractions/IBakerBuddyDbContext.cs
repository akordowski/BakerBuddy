using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakerBuddy.Data;

public interface IBakerBuddyDbContext : IDbContext
{
    DbSet<IngredientEntity> Ingredient { get; }
    DbSet<RecipeEntity> Recipe { get; }
    DbSet<UserEntity> User { get; }
}