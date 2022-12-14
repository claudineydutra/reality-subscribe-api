using Application.UseCases.Inscricoes.Create;
using AutoMapper;
using reality_subscribe_api.Model;

namespace Infra.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Subscribe, CreateInscricaoCommand>().ReverseMap();
        }
    }
}
