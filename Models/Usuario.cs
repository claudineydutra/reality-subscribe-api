using Models;

namespace reality_subscribe_api.Model
{
    public class Usuario : BaseEntity
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
