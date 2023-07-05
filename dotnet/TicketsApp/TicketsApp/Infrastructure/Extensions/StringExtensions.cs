namespace TicketsApp.Infrastructure.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string value)
    {
        return string.IsNullOrEmpty(value);
    }

    public static bool HasNonEmptyValue(this string value)
    {
        return !value.IsNullOrEmpty();
    }
}