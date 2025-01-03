using Geo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geo.Infra.Data.EntityConfig;

internal class LocalConfigEntity : IEntityTypeConfiguration<Local>
{
    public void Configure(EntityTypeBuilder<Local> builder)
    {
        builder.ToTable("LOCAL");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome).IsRequired().HasMaxLength(75);
        builder.Property(x => x.Categoria).IsRequired().HasMaxLength(50);

        builder.Property(x => x.Coordenadas)
           .IsRequired()
           .HasColumnType("geography (point, 4326)");
    }
}
