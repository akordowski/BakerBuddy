using BakerBuddy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakerBuddy.Data.Configurations.Tables;

public class IngredientEntityConfiguration : TableEntityConfiguration<IngredientEntity>
{
    public IngredientEntityConfiguration()
        : base("Ingredient", "dbo")
    {
    }

    public override void Configure(EntityTypeBuilder<IngredientEntity> builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        base.Configure(builder);

        builder.HasKey(e => e.IngredientId);

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

        builder.Property(e => e.Amount);

        builder.HasOne(d => d.Recipe)
            .WithMany(p => p.Ingredients)
            .HasForeignKey(d => d.IngredientId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Ingredient_Recipe");
    }
}