using MediatR;

namespace Application.UseCases.Inscricoes.Create
{
    public class CreateInscricaoCommand : IRequest<InscricaoValidationResult>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string AttachmentImage { get; set; }
        public string AttachmentVideo { get; set; }
        public string Video { get; set; }
    }
}
