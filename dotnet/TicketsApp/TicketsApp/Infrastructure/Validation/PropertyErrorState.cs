namespace TicketsApp.Infrastructure.Validation;

public record PropertyErrorState(string PropertyName, string ErrorMessage) { }