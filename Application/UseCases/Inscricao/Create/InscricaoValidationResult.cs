using FluentValidation.Results;

namespace Application.UseCases.Inscricao.Create
{
    public class InscricaoValidationResult : ValidationResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
