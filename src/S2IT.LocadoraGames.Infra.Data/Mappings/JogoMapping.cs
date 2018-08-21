using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Mappings
{
    public class JogoMapping : EntityTypeConfiguration<Jogo>
    {
        public override void Map(EntityTypeBuilder<Jogo> builder)
        {
            builder.Property(j => j.JogoId)
                .IsRequired();

            builder.Property(j => j.DataEmprestimo)
                .HasColumnType("DateTime");
                

            builder.Property(j => j.DataDevolucao)
                .HasColumnType("DateTime");

            builder.Property(j => j.Titulo)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.ToTable("Jogos").HasKey(j => j.JogoId);

            builder.HasOne(j => j.Amigo)
                .WithMany(j => j.Jogos)
                .HasForeignKey(j => j.AmigoId)
                .IsRequired(false);
                

        }
    }
}
