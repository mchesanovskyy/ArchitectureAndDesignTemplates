using TicketsApp.Infrastructure.Extensions;
using TicketsApp.Infrastructure.Validation;

namespace TicketsApp.MVC.Views.Helpers;

public static class ConsoleHelper
{
    public static string ReadParameter(string question)
    {
        Console.Write(question);
        var value = Console.ReadLine();

        return value ?? string.Empty;
    }

    public static T ReadParameter<T>(string question, T defaultValue = default!)
    {
        return ReadParameter(question)
            .ToType<T>();
    }

    public static void ReadParameterIfInvalid(string question, string parameterName, ModelState? modelState,
        Action<string> onUpdateAction)
    {
        if (modelState != null && modelState.IsValidPropertyState(parameterName))
        {
            return;
        }

        var value = ReadParameter(question);
        onUpdateAction(value);
    }

    public static void ReadParameterIfInvalid<T>(string question, string parameterName, ModelState? modelState,
        Action<T> onUpdateAction)
    {
        if (modelState != null && modelState.IsValidPropertyState(parameterName))
        {
            return;
        }

        var value = ReadParameter<T>(question);
        onUpdateAction(value);
    }
}