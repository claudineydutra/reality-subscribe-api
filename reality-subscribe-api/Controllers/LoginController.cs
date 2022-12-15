using Application.UseCases.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace reality_subscribe_api.Controllers
{
    public class LoginController : RealityControllerBase
    {
        public readonly IMediator _mediator;
        public LoginController(IMediator mediator, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginCommand login)
        {
            var result = await _mediator.Send(login);
            return new ObjectResult(result);
        }
    }
}
