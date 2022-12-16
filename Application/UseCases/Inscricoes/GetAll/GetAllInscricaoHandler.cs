using Application.Infra;
using AutoMapper;
using MediatR;
using reality_subscribe_api.Model;

namespace Application.UseCases.Inscricoes.GetAll
{
    public class GetAllInscricaoHandler : IRequestHandler<GetAllInscricaoCommand, GetAllInscricaoCommandResult>
    {
        private readonly IARepository<Subscribe> _repository;
        private readonly IMapper _mapper;

        public GetAllInscricaoHandler(IARepository<Subscribe> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAllInscricaoCommandResult> Handle(GetAllInscricaoCommand request, CancellationToken cancellationToken)
        {
            var resultQuery = _repository.ToListAsync();

            GetAllInscricaoCommandResult result = new GetAllInscricaoCommandResult
            {
                InscricaoResult = resultQuery.Result
            };

            return result;


        }
    }
}
