﻿using Application.UseCases.Inscricoes.Create;
using Application.UseCases.Login;
using Application.UseCases.Register;
using AutoMapper;
using reality_subscribe_api.Model;

namespace Infra.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Subscribe, CreateInscricaoCommand>().ReverseMap();
            CreateMap<User, LoginCommand>().ReverseMap();
            CreateMap<User, RegisterCommand>().ReverseMap();
        }
    }
}
