using Application.UseCases.Inscricao.Create;
using AutoMapper;
using reality_subscribe_api.Model;

namespace Infra.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Inscricao, CreateInscricaoCommand>().ReverseMap();
        }
    }
}
