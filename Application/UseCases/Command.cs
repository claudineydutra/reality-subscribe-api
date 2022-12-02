using FluentValidation;
using FluentValidation.Results;

namespace Application.UseCases
{
    public abstract class Command<T, X> where T : AbstractValidator<X>, new()
    {
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            var validator = new T();
            ValidationResult = validator.Validate((X)(object)this);
            return ValidationResult.IsValid;
        }
        public void AddValidationError(string propertyName, string message)
        {
            ValidationResult.Errors.Add(new ValidationFailure(propertyName, message));
        }
    }
}
