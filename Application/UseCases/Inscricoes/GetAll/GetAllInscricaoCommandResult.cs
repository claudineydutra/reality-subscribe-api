using ICM.Core.Application.Common;
using reality_subscribe_api.Model;

namespace Application.UseCases.Inscricoes.GetAll
{
    public class GetAllInscricaoCommandResult
    {
        public List<Subscribe> InscricaoResult { get; set; }
    }
}