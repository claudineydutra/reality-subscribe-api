using Application.Infra;
using DevOne.Security.Cryptography.BCrypt;
using MediatR;
using reality_subscribe_api.Model;

namespace Application.UseCases.Login
{
    public class LoginHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        private readonly IARepository<Subscribe> _subscribeRepository;

        public LoginHandler(IARepository<Subscribe> subscribeRepository)
        {
            _subscribeRepository = subscribeRepository;
        }

        public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {

            var user = _subscribeRepository.Queryable()
                .Where(x => x.Email == request.UserName)
                .FirstOrDefault();

            if (user == null)
            {
                return new LoginCommandResult
                {
                    hasLogin = false,
                    Message = "Usuario nao existe",
                };
            }

            if (!BCryptHelper.CheckPassword(request.Password, user.Senha))
            {
                return new LoginCommandResult
                {
                    hasLogin = false,
                    Message = "Senha incorreta",
                };
            }

            return new LoginCommandResult
            {
                hasLogin = true,
                Message = "Login OK",
            };
        }
    }
}
