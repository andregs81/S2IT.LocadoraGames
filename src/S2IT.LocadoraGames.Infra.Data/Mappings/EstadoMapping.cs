using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Mappings
{
    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public override void Map(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado")
                .HasKey(e => e.UF);

            builder.Property(e => e.UF)
                .IsRequired()
                .HasColumnType("Char(2)");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("Varchar(100)");

            builder.HasMany(e => e.Cidades)
                .WithOne(c => c.Estado)
                .HasForeignKey(e => e.UF);
        }
    }
}
