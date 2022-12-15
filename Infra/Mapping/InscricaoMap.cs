using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reality_subscribe_api.Model;

namespace Infra.Mapping
{
    public class InscricaoMap : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email);
            builder.Property(x => x.Nome);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.Senha);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.ModifieddDate);
        }
    }
}
