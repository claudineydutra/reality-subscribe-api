using Application.UseCases.Inscricao.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace reality_subscribe_api.Controllers
{
    public class InscricaoController : RealityControllerBase
    {
        public readonly IMediator _mediator;
        public InscricaoController(IMediator mediator, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateInscricaoCommand inscricao)
        {
            var validationResult = await _mediator.Send(inscricao);
            if (!validationResult.IsValid)
            {
                return ValidationError(validationResult.Errors);
            }
            return Ok(validationResult);
        }
    }
}
