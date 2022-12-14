using FluentValidation;

namespace Application.UseCases.Inscricao.Update
{
    public class UpdateInscricaoValidator : AbstractValidator<UpdateInscricaoCommand>
    {
        public UpdateInscricaoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Por favor informe o ID");
        }
    }
}
