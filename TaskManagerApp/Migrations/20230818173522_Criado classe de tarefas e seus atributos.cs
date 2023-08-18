using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class Criadoclassedetarefaseseusatributos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    CodTarefa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTarefa = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescricaoTarefa = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataVencimentoTarefa = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PrioridadeTarefa = table.Column<int>(type: "int", nullable: false),
                    SituacaoTarefa = table.Column<int>(type: "int", nullable: false),
                    UsuarioCodUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.CodTarefa);
                    table.ForeignKey(
                        name: "FK_Tarefas_USUARIOS_UsuarioCodUsuario",
                        column: x => x.UsuarioCodUsuario,
                        principalTable: "USUARIOS",
                        principalColumn: "COD_USUARIO");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_UsuarioCodUsuario",
                table: "Tarefas",
                column: "UsuarioCodUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
