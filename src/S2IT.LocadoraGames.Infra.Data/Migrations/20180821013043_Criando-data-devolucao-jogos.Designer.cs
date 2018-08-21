﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using S2IT.LocadoraGames.Infra.Data.Context;

namespace S2IT.LocadoraGames.Infra.Data.Migrations
{
    [DbContext(typeof(LocadoraGamesContext))]
    [Migration("20180821013043_Criando-data-devolucao-jogos")]
    partial class Criandodatadevolucaojogos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Amigos.Amigo", b =>
                {
                    b.Property<int>("AmigoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apelido")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("AmigoId");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Amigo");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Geografia.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("UF");

                    b.HasKey("CidadeId");

                    b.HasIndex("UF");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Geografia.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("Varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Cep")
                        .HasColumnType("Varchar(8)")
                        .HasMaxLength(8);

                    b.Property<int>("CidadeId");

                    b.Property<string>("Complemento")
                        .HasColumnType("Varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("Varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("EnderecoId");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Geografia.Estado", b =>
                {
                    b.Property<string>("UF")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Char(2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("UF");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Jogos.Jogo", b =>
                {
                    b.Property<int>("JogoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmigoId");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("DataEmprestimo")
                        .HasColumnType("DateTime");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("JogoId");

                    b.HasIndex("AmigoId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Amigos.Amigo", b =>
                {
                    b.HasOne("S2IT.LocadoraGames.Domain.Entities.Geografia.Endereco", "Endereco")
                        .WithOne("Amigo")
                        .HasForeignKey("S2IT.LocadoraGames.Domain.Entities.Amigos.Amigo", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Geografia.Cidade", b =>
                {
                    b.HasOne("S2IT.LocadoraGames.Domain.Entities.Geografia.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("UF");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Geografia.Endereco", b =>
                {
                    b.HasOne("S2IT.LocadoraGames.Domain.Entities.Geografia.Cidade", "Cidade")
                        .WithMany("Enderecos")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Jogos.Jogo", b =>
                {
                    b.HasOne("S2IT.LocadoraGames.Domain.Entities.Amigos.Amigo", "Amigo")
                        .WithMany("Jogos")
                        .HasForeignKey("AmigoId");
                });
#pragma warning restore 612, 618
        }
    }
}
