namespace TicketsApp.Infrastructure.Extensions;

public static class TypeExtensions
{
    public static T ToType<T>(this object? value, T defaultValue = default!)
    {
        var changedValue = ChangeType(value, typeof(T));
        return changedValue == null
            ? defaultValue
            : (T)changedValue;
    }

    private static object? ChangeType(object? value, Type type)
    {
        if (value is null or DBNull)
        {
            return null;
        }

        var valueType = value.GetType();
        if (valueType == type)
        {
            return value;
        }

        try
        {
            return Convert.ChangeType(value, type);
        }
        catch (Exception)
        {
            return default;
        }
    }
}