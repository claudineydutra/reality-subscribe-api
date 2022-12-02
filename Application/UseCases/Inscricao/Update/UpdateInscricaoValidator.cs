using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
