using Models;

namespace reality_subscribe_api.Model
{
    public class Subscribe : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string AttachmentImage { get; set; }
        public string AttachmentVideo { get; set; }
        public bool Checked { get; set; } = false;
    }
}
