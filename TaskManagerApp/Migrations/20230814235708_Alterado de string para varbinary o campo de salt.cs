using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class Alteradodestringparavarbinaryocampodesalt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "SALT_SENHA_USUARIO",
                table: "usuarios",
                type: "varbinary(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SALT_SENHA_USUARIO",
                table: "usuarios",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(byte[]),
                oldType: "varbinary(250)",
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
