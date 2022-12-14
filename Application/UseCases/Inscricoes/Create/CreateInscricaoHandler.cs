using AutoMapper;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using reality_subscribe_api.Model;

namespace Application.UseCases.Inscricoes.Create
{
    public class CreateInscricaoHandler : IRequestHandler<CreateInscricaoCommand, ValidationResult>
    {
        private readonly IMapper _mapper;

        public CreateInscricaoHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ValidationResult> Handle(CreateInscricaoCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return request.ValidationResult;
            }

            var inscricao = _mapper.Map<Subscribe>(request);

            return new InscricaoValidationResult
            {
                Nome = request.Nome,
                Email = request.Email,
                ValidationResult = request.ValidationResult,
            };
        }
    }
}
