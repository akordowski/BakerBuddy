namespace BakerBuddy.Api.Extensions;

public static class ConfigurationExtensions
{
    public static T GetOptions<T>(this IConfiguration configuration, string section)
        where T : class, new()
    {
        if (configuration is null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        return configuration.GetSection(section).Get<T>() ?? new T();
    }
}