﻿using FluentValidation.Results;
using MediatR;

namespace Application.UseCases.Inscricao.Create
{
    public class CreateInscricaoCommand : Command<CreateInscricaoValidator, CreateInscricaoCommand>, IRequest<ValidationResult>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
