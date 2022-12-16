using Application.Infra;
using AutoMapper;
using FluentValidation.Results;
using MediatR;
using reality_subscribe_api.Model;

namespace Application.UseCases.Inscricoes.Create
{
    public class CreateInscricaoHandler : IRequestHandler<CreateInscricaoCommand, ValidationResult>
    {
        private readonly IMapper _mapper;
        private readonly IARepository<Subscribe> _inscricaoRepository;

        public CreateInscricaoHandler(IMapper mapper, IARepository<Subscribe> inscricaoRepository)
        {
            _mapper = mapper;
            _inscricaoRepository = inscricaoRepository;
        }

        public async Task<ValidationResult> Handle(CreateInscricaoCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return request.ValidationResult;
            }
            var inscricao = _mapper.Map<Subscribe>(request);

            _inscricaoRepository.Insert(inscricao);
            _inscricaoRepository.Commit();

            return new InscricaoValidationResult
            {
                Id = inscricao.Id,
                Nome = request.Nome,
                Email = request.Email,
                DataNascimento = request.DataNascimento,
            };
        }
    }
}
