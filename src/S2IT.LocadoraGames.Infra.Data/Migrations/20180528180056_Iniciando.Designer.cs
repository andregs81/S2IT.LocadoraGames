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
    [Migration("20180528180056_Iniciando")]
    partial class Iniciando
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

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("AmigoId");

                    b.ToTable("Amigo");
                });

            modelBuilder.Entity("S2IT.LocadoraGames.Domain.Entities.Jogos.Jogo", b =>
                {
                    b.Property<int>("JogoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmigoId");

                    b.Property<DateTime?>("DataEmprestimo")
                        .HasColumnType("DateTime");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("JogoId");

                    b.HasIndex("AmigoId");

                    b.ToTable("Jogos");
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
