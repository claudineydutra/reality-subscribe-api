using Application.UseCases.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace reality_subscribe_api.Controllers
{
    public class AuthController : RealityControllerBase
    {
        public readonly IMediator _mediator;
        public AuthController(IMediator mediator, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> Login([FromBody] LoginCommand login)
        {
            var result = await _mediator.Send(login);
            return new ObjectResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] LoginCommand login)
        {
            var result = await _mediator.Send(login);
            return new ObjectResult(result);
        }
    }
}
