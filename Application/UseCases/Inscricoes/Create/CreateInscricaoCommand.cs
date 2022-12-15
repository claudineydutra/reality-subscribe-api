using FluentValidation.Results;
using MediatR;

namespace Application.UseCases.Inscricoes.Create
{
    public class CreateInscricaoCommand : Command<CreateInscricaoValidator, CreateInscricaoCommand>, IRequest<ValidationResult>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
