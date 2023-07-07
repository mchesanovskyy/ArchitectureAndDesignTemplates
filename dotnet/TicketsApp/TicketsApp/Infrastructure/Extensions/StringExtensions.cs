namespace TicketsApp.Infrastructure.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string? value)
    {
        return string.IsNullOrEmpty(value);
    }

    public static bool HasNonEmptyValue(this string? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool EqualsIgnoreCase(this string? value, string? value2)
    {
        return string.Equals(value, value2, StringComparison.OrdinalIgnoreCase);
    }
}