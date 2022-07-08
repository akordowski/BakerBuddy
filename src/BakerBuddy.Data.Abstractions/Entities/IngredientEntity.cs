namespace BakerBuddy.Data.Entities;

public class IngredientEntity
{
    public int IngredientId { get; set; }

    public string Name { get; set; } = default!;

    public int Amount { get; set; } = default!;

    public RecipeEntity Recipe { get; set; } = default!;
}