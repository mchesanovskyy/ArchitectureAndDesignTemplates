using System.Text.Json;

namespace TicketsApp.Infrastructure.Extensions;

public static class JsonExtensions
{
    public static string ToJsonString<T>(this T value)
    {
        return JsonSerializer.Serialize(value);
    }

    public static T? TryParseString<T>(this string value, T defaultValue = default)
    {
        try
        {
            return JsonSerializer.Deserialize<T>(value);
        }
        catch
        {
            return defaultValue;
        }
    }
}