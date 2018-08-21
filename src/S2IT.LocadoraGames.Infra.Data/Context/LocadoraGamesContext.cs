using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using S2IT.LocadoraGames.Infra.Data.Mappings;
using System.IO;

namespace S2IT.LocadoraGames.Infra.Data.Context
{
    public class LocadoraGamesContext : DbContext
    {
        public DbSet<Amigo> Amigo { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Estado> Estado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new AmigoMapping());
            modelBuilder.AddConfiguration(new JogoMapping());
            modelBuilder.AddConfiguration(new EnderecoMapping());
            modelBuilder.AddConfiguration(new CidadeMapping());
            modelBuilder.AddConfiguration(new EstadoMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
