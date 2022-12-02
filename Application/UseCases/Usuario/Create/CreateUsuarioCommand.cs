using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Usuario.Create
{
    public class CreateUsuarioCommand : Command<CreateUsuarioValidation, CreateUsuarioCommand>, IRequest<ValidationResult>
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
