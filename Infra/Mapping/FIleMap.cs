using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Models.File;

namespace Infra.Mapping
{
    public class FIleMap : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.HasKey(x=> x.Id);

            builder.Property(x => x.Name);
            builder.Property(x => x.Attachment);
            builder.Property(x => x.Type);
        }
    }
}
