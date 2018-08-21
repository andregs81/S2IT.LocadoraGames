using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Mappings
{
    public class CidadeMapping : EntityTypeConfiguration<Cidade>
    {
        public override void Map(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidade")
                .HasKey(c => c.CidadeId);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("Varchar(150)");

            builder.HasOne(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasForeignKey(c => c.UF);
        }
    }
}
