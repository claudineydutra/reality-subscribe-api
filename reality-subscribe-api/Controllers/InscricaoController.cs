using Application.UseCases.Inscricoes.Create;
using Application.UseCases.Inscricoes.GetAll;
using ICM.Core.Application.Common;
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

        [HttpGet("getall")]
        public async Task<ActionResult<GetAllInscricaoCommandResult>> GetAll([FromQuery] GetAllInscricaoCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
