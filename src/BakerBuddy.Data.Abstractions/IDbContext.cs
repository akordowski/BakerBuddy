using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakerBuddy.Data;

public interface IDbContext
{
    DbSet<UserEntity> User { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default);
}