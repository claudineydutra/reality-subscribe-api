﻿using FluentValidation.Results;

namespace Application.UseCases.Inscricoes.Create
{
    public class InscricaoValidationResult : ValidationResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}