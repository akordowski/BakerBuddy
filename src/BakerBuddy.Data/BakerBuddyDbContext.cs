using BakerBuddy.Data.Configurations.Tables;
using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakerBuddy.Data;

public class BakerBuddyDbContext : DbContext, IDbContext
{
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
        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
    }
}