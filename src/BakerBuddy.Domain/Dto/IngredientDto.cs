namespace BakerBuddy.Domain.Dto;

public class IngredientDto
{
    public int IngredientId { get; set; }

    public string Name { get; set; } = default!;

    public uint Amount { get; set; } = default!;
}