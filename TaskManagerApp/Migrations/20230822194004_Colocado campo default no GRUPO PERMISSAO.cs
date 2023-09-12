using Microsoft.EntityFrameworkCore.Migrations;
using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class ColocadocampodefaultnoGRUPOPERMISSAO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GRUPO_PERMISSAO",
                table: "usuarios",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                defaultValueSql: "'USUARIO'",
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            Senhas senhas = new Senhas();

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] 
                {
                    "NOME_COMPLETO", "NOME_USUARIO", "SENHA_USUARIO", "DICA_SENHA", "SALT_SENHA_USUARIO", "EMAIL_USUARIO", "GRUPO_PERMISSAO"
                },
                columnTypes: new string[]
                {
                    "VARCHAR", "VARCHAR", "VARCHAR", "VARCHAR", "VARBINARY", "VARCHAR", "VARCHAR"
                }
                ,
                values: new object[] 
                {
                    "ADMINISTRADOR", "admin", senhas.CriptografarSenha("admin", out byte[] salt), null, salt, null, "ADMINISTRADOR"
                }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GRUPO_PERMISSAO",
                table: "usuarios",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true,
                oldDefaultValueSql: "'USUARIO'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");
        }
    }
}
