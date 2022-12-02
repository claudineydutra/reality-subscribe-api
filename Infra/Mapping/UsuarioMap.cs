using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reality_subscribe_api.Model;

namespace Infra.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email);
            builder.Property(x => x.Senha);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.ModifieddDate);
        }
    }
}
