using BakerBuddy.Data.Configurations.Tables;
using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakerBuddy.Data;

public class BakerBuddyDbContext : DbContext, IBakerBuddyDbContext
{
    public DbSet<IngredientEntity> Ingredient => Set<IngredientEntity>();
    public DbSet<RecipeEntity> Recipe => Set<RecipeEntity>();
    public DbSet<UserEntity> User => Set<UserEntity>();

    public BakerBuddyDbContext()
    {
    }

    public BakerBuddyDbContext(DbContextOptions<BakerBuddyDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder is null)
        {
            throw new ArgumentNullException(nameof(modelBuilder));
        }

        // Tables
        modelBuilder.ApplyConfiguration(new IngredientEntityConfiguration());
        modelBuilder.ApplyConfiguration(new RecipeEntityConfiguration());
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
    }
}