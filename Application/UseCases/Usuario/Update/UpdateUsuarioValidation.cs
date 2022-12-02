using FluentValidation;

namespace Application.UseCases.Usuario.Update
{
    public class UpdateUsuarioValidation : AbstractValidator<UpdateUsuarioCommand>
    {
        public UpdateUsuarioValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Por favor informe o ID");
        }
    }
}