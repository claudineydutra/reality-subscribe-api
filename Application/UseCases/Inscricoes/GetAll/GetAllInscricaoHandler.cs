using Application.Infra;
using MediatR;
using reality_subscribe_api.Model;

namespace Application.UseCases.Inscricoes.GetAll
{
    public class GetAllInscricaoHandler : IRequestHandler<GetAllInscricaoCommand, GetAllInscricaoCommandResult>
    {
        private readonly IARepository<Subscribe> _repository;

        public GetAllInscricaoHandler(IARepository<Subscribe> repository)
        {
            _repository = repository;
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
