namespace BakerBuddy.Data.Entities;

public class UserEntity
{
    public UserEntity()
    {
        Recipes = new HashSet<RecipeEntity>();
    }

    public int UserId { get; set; }

    public string UserName { get; set; } = default!;

    public string Password { get; set; } = default!;

    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string Email { get; set; } = default!;

    public ICollection<RecipeEntity> Recipes { get; }
}