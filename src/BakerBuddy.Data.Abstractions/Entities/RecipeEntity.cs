namespace BakerBuddy.Data.Entities;

public class RecipeEntity
{
    public RecipeEntity()
    {
        Ingredients = new HashSet<IngredientEntity>();
    }

    public int RecipeId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public string Instructions { get; set; } = default!;

    public ulong Likes { get; set; }

    public ICollection<IngredientEntity> Ingredients { get; }

    public UserEntity User { get; } = default!;
}