using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Mappings
{
    public class AmigoMapping : EntityTypeConfiguration<Amigo>
    {
        public override void Map(EntityTypeBuilder<Amigo> builder)
        {
            builder.Property(a => a.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(a => a.Sobrenome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(a => a.Apelido)
                .HasColumnType("varchar(100)");

            builder.Property(a => a.Celular)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(a => a.EnderecoId)
                .HasColumnType("int");

            builder.ToTable("Amigo")
                .HasKey(a => a.AmigoId);

            builder.HasMany(a => a.Jogos);

            builder.HasOne(a => a.Endereco)
                .WithOne(e => e.Amigo);
                

        }
    }
}
