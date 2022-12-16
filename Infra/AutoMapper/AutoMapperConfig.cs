using Application.UseCases.Inscricoes.Create;
using Application.UseCases.Login;
using AutoMapper;
using Models;
using reality_subscribe_api.Model;

namespace Infra.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Subscribe, CreateInscricaoCommand>().ReverseMap();
            CreateMap<User, LoginCommand>().ReverseMap();
        }
    }
}
