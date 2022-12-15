using FluentValidation;

namespace Application.UseCases.Inscricoes.Create
{
    public class CreateInscricaoValidator : AbstractValidator<CreateInscricaoCommand>
    {
        public CreateInscricaoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Por favor informe o Nome");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Por favor informe o  Email");

            RuleFor(x => x.DataNascimento).NotEmpty().WithMessage("Por favor informe a Data de nascimento");
        }
    }
}