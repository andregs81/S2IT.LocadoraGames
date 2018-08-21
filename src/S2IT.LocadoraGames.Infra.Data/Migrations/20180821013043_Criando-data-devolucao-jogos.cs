using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace S2IT.LocadoraGames.Infra.Data.Migrations
{
    public partial class Criandodatadevolucaojogos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDevolucao",
                table: "Jogos",
                type: "DateTime",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDevolucao",
                table: "Jogos");
        }
    }
}
