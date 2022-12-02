using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Inscricao.Create
{
    public class CreateInscricaoCommand : Command<CreateInscricaoValidator, CreateInscricaoCommand>, IRequest<ValidationResult>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
