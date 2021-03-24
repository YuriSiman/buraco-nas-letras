using BuracoNasLetras.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuracoNasLetras.Data.Mappings
{
    public class PapelMapping : IEntityTypeConfiguration<Papel>
    {
        public void Configure(EntityTypeBuilder<Papel> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Texto)
                .IsRequired();

            builder.ToTable("Papeis");
        }
    }
}
