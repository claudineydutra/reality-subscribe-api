using Application.UseCases.Inscricoes.Create;
using Application.UseCases.Inscricoes.GetAll;
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

        [HttpPost("Create")]
        public async Task<ActionResult> Create(CreateInscricaoCommand inscricao)
        {
            var result = await _mediator.Send(inscricao);

            return Ok(result);
        }

        [HttpGet("Getall")]
        public async Task<ActionResult<GetAllInscricaoCommandResult>> GetAll([FromQuery] GetAllInscricaoCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
