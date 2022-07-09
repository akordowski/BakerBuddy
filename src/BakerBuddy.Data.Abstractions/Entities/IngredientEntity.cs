namespace BakerBuddy.Data.Entities;

public class IngredientEntity
{
    public int IngredientId { get; set; }

    public int RecipeId { get; set; }

    public string Name { get; set; } = default!;

    public uint Amount { get; set; } = default!;

    public RecipeEntity Recipe { get; set; } = default!;
}