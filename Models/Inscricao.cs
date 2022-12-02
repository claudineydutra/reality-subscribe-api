using Models;

namespace reality_subscribe_api.Model
{
    public class Inscricao : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
