using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakerBuddy.Data.Configurations;

public abstract class TableEntityConfiguration<TEntity>
    : IEntityTypeConfiguration<TEntity> where TEntity : class
{
    private readonly string _name;
    private readonly string _schema;

    protected TableEntityConfiguration(string name, string schema)
    {
        _name = name;
        _schema = schema;
    }

    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(_name, _schema);
    }
}