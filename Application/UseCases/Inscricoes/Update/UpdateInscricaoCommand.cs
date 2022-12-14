using FluentValidation.Results;
using MediatR;

namespace Application.UseCases.Inscricao.Update
{
    public class UpdateInscricaoCommand : Command<UpdateInscricaoValidator, UpdateInscricaoCommand>, IRequest<ValidationResult>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
