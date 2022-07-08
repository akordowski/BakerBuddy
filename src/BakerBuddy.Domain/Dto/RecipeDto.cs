namespace BakerBuddy.Domain.Dto;

public class RecipeDto
{
    public int RecipeId { get; set; }

    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public string Instructions { get; set; } = default!;

    public ulong Likes { get; set; }
}