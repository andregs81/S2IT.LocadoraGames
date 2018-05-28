using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace S2IT.LocadoraGames.Infra.Data.Migrations
{
    public partial class Iniciando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigo",
                columns: table => new
                {
                    AmigoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Apelido = table.Column<string>(type: "varchar(100)", nullable: true),
                    Celular = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigo", x => x.AmigoId);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    JogoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "DateTime", nullable: true),
                    AmigoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.JogoId);
                    table.ForeignKey(
                        name: "FK_Jogos_Amigo_AmigoId",
                        column: x => x.AmigoId,
                        principalTable: "Amigo",
                        principalColumn: "AmigoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_AmigoId",
                table: "Jogos",
                column: "AmigoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Amigo");
        }
    }
}
