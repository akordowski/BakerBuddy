using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakerBuddy.Data.Configurations.Tables;

public class RecipeEntityConfiguration : TableEntityConfiguration<RecipeEntity>
{
    public RecipeEntityConfiguration()
        : base("Recipe", "dbo")
    {
    }

    public override void Configure(EntityTypeBuilder<RecipeEntity> builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        base.Configure(builder);

        builder.HasKey(e => e.RecipeId);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.Instructions)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.Likes);

        builder.HasOne(d => d.User)
            .WithMany(p => p.Recipes)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Recipe_User");
    }
}