using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class adicionadocampoparacontrolargruposepermissoesadministrativasnobanco2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GrupoPermissao",
                table: "USUARIOS",
                newName: "GRUPO_PERMISSAO");

            migrationBuilder.AlterColumn<string>(
                name: "GRUPO_PERMISSAO",
                table: "USUARIOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GRUPO_PERMISSAO",
                table: "USUARIOS",
                newName: "GrupoPermissao");

            migrationBuilder.AlterColumn<string>(
                name: "GrupoPermissao",
                table: "USUARIOS",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");
        }
    }
}
