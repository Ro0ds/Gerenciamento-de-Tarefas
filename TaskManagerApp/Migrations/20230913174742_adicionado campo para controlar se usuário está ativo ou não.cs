using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class adicionadocampoparacontrolarseusuárioestáativoounão : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "USUARIO_ATIVO",
                table: "usuarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValueSql: "TRUE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USUARIO_ATIVO",
                table: "usuarios");
        }
    }
}
