using Application.UseCases.Login;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Register
{
    public class RegisterCommand : IRequest<RegisterCommandResult>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
