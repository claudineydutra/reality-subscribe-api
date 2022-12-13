using FluentValidation.Results;
using MediatR;

namespace Application.UseCases.Inscricao.Create
{
    public class CreateInscricaoHandler : IRequestHandler<CreateInscricaoCommand, ValidationResult>
    {
        public Task<ValidationResult> Handle(CreateInscricaoCommand request, CancellationToken cancellationToken)
        {
            if(!request .IsValid())
            {
                return request.ValidationResult;
            }

            return new InscricaoValidationResult
            {
                Nome = request.Nome,
                Email= request.Email,
                ValidationResult = request.ValidationResult,

            };
        }
    }
}
