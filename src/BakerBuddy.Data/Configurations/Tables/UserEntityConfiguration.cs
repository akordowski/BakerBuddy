using BakerBuddy.Data.Abstractions.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakerBuddy.Data.Configurations.Tables;

public class UserEntityConfiguration : TableEntityConfiguration<UserEntity>
{
    public UserEntityConfiguration()
        : base("User", "dbo")
    {
    }

    public override void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        base.Configure(builder);

        builder.HasKey(e => e.UserId);

        builder.Property(e => e.UserName)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.Password)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
    }
}