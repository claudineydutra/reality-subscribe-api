using FluentValidation;

namespace Application.UseCases.Usuario.Create
{
    public class CreateUsuarioValidation : AbstractValidator<CreateUsuarioCommand>
    {
        public CreateUsuarioValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Por favor informe o Nome");

            RuleFor(x => x.Senha).NotEmpty().WithMessage("Por favor informe o  Senha");
        }
    }
}