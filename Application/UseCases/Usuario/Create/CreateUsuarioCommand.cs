using FluentValidation.Results;
using MediatR;

namespace Application.UseCases.Usuario.Create
{
    public class CreateUsuarioCommand : Command<CreateUsuarioValidation, CreateUsuarioCommand>, IRequest<ValidationResult>
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
