using MediatR;

namespace Application.UseCases.Login
{
    public class LoginCommand : IRequest<LoginCommandResult>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
