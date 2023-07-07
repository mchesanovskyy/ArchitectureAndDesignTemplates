using TicketsApp.Infrastructure.Extensions;

namespace TicketsApp.Infrastructure.Validation
{
    public class ModelState
    {
        public ModelState()
        {
            PropertyErrors = new List<PropertyErrorState>(0);
        }

        public ModelState(string errorMessage)
            : this()
        {
            ErrorMessage = errorMessage;
        }

        public bool IsValid => ErrorMessage.IsNullOrEmpty() && PropertyErrors.Count == 0;

        public string? ErrorMessage { get; set; }

        public ICollection<PropertyErrorState> PropertyErrors { get; }

        public ModelState AddPropertyError(string propertyName, string errorMessage)
        {
            PropertyErrors.Add(new PropertyErrorState(propertyName, errorMessage));
            return this;
        }

        public bool IsValidPropertyState(string propertyName)
        {
            return !PropertyErrors.Any(e => e.PropertyName.EqualsIgnoreCase(propertyName));
        }
    }
}
