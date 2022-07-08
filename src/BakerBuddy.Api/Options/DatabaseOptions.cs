namespace BakerBuddy.Api.Options;

public class DatabaseOptions
{
    public const string Section = "Database";

    public int CommandTimeoutInSeconds { get; set; } = 300;

    public bool EnableDetailedErrors { get; set; }

    public bool EnableSensitiveDataLogging { get; set; }
}