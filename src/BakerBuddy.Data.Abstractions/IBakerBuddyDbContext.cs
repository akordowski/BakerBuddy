using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakerBuddy.Data;

public interface IBakerBuddyDbContext : IDbContext
{
    DbSet<UserEntity> User { get; }
}