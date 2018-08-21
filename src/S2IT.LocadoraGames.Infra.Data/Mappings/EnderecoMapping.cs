using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco")
                .HasKey(e => e.EnderecoId);

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("Varchar(150)");

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("Varchar(20)");

            builder.Property(e => e.Complemento)
                .HasMaxLength(150)
                .HasColumnType("Varchar(150)");

            builder.Property(e => e.Cep)
                .HasMaxLength(8)
                .HasColumnType("Varchar(8)");

            builder.Property(e => e.Bairro)
                .HasMaxLength(100)
                .HasColumnType("Varchar(100)");


            builder.HasOne(e => e.Cidade)
                .WithMany(c => c.Enderecos);
        }
    }
}
