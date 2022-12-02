using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Usuario.Update
{
    public class UpdateUsuarioCommand : Command<UpdateUsuarioValidation, UpdateUsuarioCommand>, IRequest<ValidationResult>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
