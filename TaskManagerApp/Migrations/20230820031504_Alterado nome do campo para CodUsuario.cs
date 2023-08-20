using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class AlteradonomedocampoparaCodUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_USUARIOS_UsuarioCodUsuario",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_UsuarioCodUsuario",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "UsuarioCodUsuario",
                table: "Tarefas");

            migrationBuilder.AddColumn<int>(
                name: "CodUsuario",
                table: "Tarefas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodUsuario",
                table: "Tarefas");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioCodUsuario",
                table: "Tarefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_UsuarioCodUsuario",
                table: "Tarefas",
                column: "UsuarioCodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_USUARIOS_UsuarioCodUsuario",
                table: "Tarefas",
                column: "UsuarioCodUsuario",
                principalTable: "USUARIOS",
                principalColumn: "COD_USUARIO");
        }
    }
}
