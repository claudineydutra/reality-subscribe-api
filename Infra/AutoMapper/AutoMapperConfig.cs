using Application.UseCases.Inscricao.Create;
using AutoMapper;
using reality_subscribe_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
