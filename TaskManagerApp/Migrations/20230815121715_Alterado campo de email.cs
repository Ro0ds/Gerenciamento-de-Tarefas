using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class Alteradocampodeemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "USUARIOS");

            migrationBuilder.RenameColumn(
                name: "EmailUsuario",
                table: "USUARIOS",
                newName: "EMAIL_USUARIO");

            migrationBuilder.RenameIndex(
                name: "IX_usuarios_NOME_USUARIO",
                table: "USUARIOS",
                newName: "IX_USUARIOS_NOME_USUARIO");

            migrationBuilder.AlterColumn<string>(
                name: "NOME_USUARIO",
                table: "USUARIOS",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL_USUARIO",
                table: "USUARIOS",
                type: "varchar(70)",
                maxLength: 70,
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
            migrationBuilder.RenameTable(
                name: "USUARIOS",
                newName: "usuarios");

            migrationBuilder.RenameColumn(
                name: "EMAIL_USUARIO",
                table: "usuarios",
                newName: "EmailUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_USUARIOS_NOME_USUARIO",
                table: "usuarios",
                newName: "IX_usuarios_NOME_USUARIO");

            migrationBuilder.AlterColumn<string>(
                name: "NOME_USUARIO",
                table: "usuarios",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "EmailUsuario",
                table: "usuarios",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(70)",
                oldMaxLength: 70)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");
        }
    }
}
