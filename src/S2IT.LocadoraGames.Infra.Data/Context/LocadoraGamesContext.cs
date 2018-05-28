using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using S2IT.LocadoraGames.Infra.Data.Extensions;
using S2IT.LocadoraGames.Infra.Data.Mappings;
using System.IO;

namespace S2IT.LocadoraGames.Infra.Data.Context
{
    public class LocadoraGamesContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new AmigoMapping());
            modelBuilder.AddConfiguration(new JogoMapping());

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
