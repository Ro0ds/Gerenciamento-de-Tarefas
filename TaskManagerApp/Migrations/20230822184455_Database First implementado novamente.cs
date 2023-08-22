using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApp.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseFirstimplementadonovamente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.RenameTable(
                name: "USUARIOS",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "tarefas");

            migrationBuilder.RenameIndex(
                name: "IX_USUARIOS_NOME_USUARIO",
                table: "usuarios",
                newName: "NOME_USUARIO");

            migrationBuilder.RenameColumn(
                name: "SituacaoTarefa",
                table: "tarefas",
                newName: "SITUACAO_TAREFA");

            migrationBuilder.RenameColumn(
                name: "PrioridadeTarefa",
                table: "tarefas",
                newName: "PRIORIDADE_TAREFA");

            migrationBuilder.RenameColumn(
                name: "NomeTarefa",
                table: "tarefas",
                newName: "NOME_TAREFA");

            migrationBuilder.RenameColumn(
                name: "DescricaoTarefa",
                table: "tarefas",
                newName: "DESCRICAO_TAREFA");

            migrationBuilder.RenameColumn(
                name: "DataVencimentoTarefa",
                table: "tarefas",
                newName: "DATA_VENCIMENTO_TAREFA");

            migrationBuilder.RenameColumn(
                name: "CodUsuario",
                table: "tarefas",
                newName: "COD_USUARIO");

            migrationBuilder.RenameColumn(
                name: "CodTarefa",
                table: "tarefas",
                newName: "COD_TAREFA");

            migrationBuilder.AlterColumn<string>(
                name: "SENHA_USUARIO",
                table: "usuarios",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<byte[]>(
                name: "SALT_SENHA_USUARIO",
                table: "usuarios",
                type: "varbinary(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(250)",
                oldMaxLength: 250);

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
                name: "GRUPO_PERMISSAO",
                table: "usuarios",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL_USUARIO",
                table: "usuarios",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(70)",
                oldMaxLength: 70)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "DICA_SENHA",
                table: "usuarios",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "SITUACAO_TAREFA",
                table: "tarefas",
                type: "int",
                nullable: false,
                defaultValueSql: "'1'",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PRIORIDADE_TAREFA",
                table: "tarefas",
                type: "int",
                nullable: false,
                defaultValueSql: "'1'",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOME_TAREFA",
                table: "tarefas",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO_TAREFA",
                table: "tarefas",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_VENCIMENTO_TAREFA",
                table: "tarefas",
                type: "datetime(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "tarefas",
                column: "COD_TAREFA");

            migrationBuilder.CreateIndex(
                name: "COD_USUARIO",
                table: "tarefas",
                column: "COD_USUARIO");

            migrationBuilder.AddForeignKey(
                name: "tarefas_ibfk_1",
                table: "tarefas",
                column: "COD_USUARIO",
                principalTable: "usuarios",
                principalColumn: "COD_USUARIO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "tarefas_ibfk_1",
                table: "tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "tarefas");

            migrationBuilder.DropIndex(
                name: "COD_USUARIO",
                table: "tarefas");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "USUARIOS");

            migrationBuilder.RenameTable(
                name: "tarefas",
                newName: "Tarefas");

            migrationBuilder.RenameIndex(
                name: "NOME_USUARIO",
                table: "USUARIOS",
                newName: "IX_USUARIOS_NOME_USUARIO");

            migrationBuilder.RenameColumn(
                name: "SITUACAO_TAREFA",
                table: "Tarefas",
                newName: "SituacaoTarefa");

            migrationBuilder.RenameColumn(
                name: "PRIORIDADE_TAREFA",
                table: "Tarefas",
                newName: "PrioridadeTarefa");

            migrationBuilder.RenameColumn(
                name: "NOME_TAREFA",
                table: "Tarefas",
                newName: "NomeTarefa");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO_TAREFA",
                table: "Tarefas",
                newName: "DescricaoTarefa");

            migrationBuilder.RenameColumn(
                name: "DATA_VENCIMENTO_TAREFA",
                table: "Tarefas",
                newName: "DataVencimentoTarefa");

            migrationBuilder.RenameColumn(
                name: "COD_USUARIO",
                table: "Tarefas",
                newName: "CodUsuario");

            migrationBuilder.RenameColumn(
                name: "COD_TAREFA",
                table: "Tarefas",
                newName: "CodTarefa");

            migrationBuilder.AlterColumn<string>(
                name: "SENHA_USUARIO",
                table: "USUARIOS",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<byte[]>(
                name: "SALT_SENHA_USUARIO",
                table: "USUARIOS",
                type: "varbinary(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(255)",
                oldMaxLength: 255,
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "USUARIOS",
                keyColumn: "GRUPO_PERMISSAO",
                keyValue: null,
                column: "GRUPO_PERMISSAO",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "GRUPO_PERMISSAO",
                table: "USUARIOS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "USUARIOS",
                keyColumn: "EMAIL_USUARIO",
                keyValue: null,
                column: "EMAIL_USUARIO",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL_USUARIO",
                table: "USUARIOS",
                type: "varchar(70)",
                maxLength: 70,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "DICA_SENHA",
                table: "USUARIOS",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "SituacaoTarefa",
                table: "Tarefas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "'1'");

            migrationBuilder.AlterColumn<int>(
                name: "PrioridadeTarefa",
                table: "Tarefas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "'1'");

            migrationBuilder.AlterColumn<string>(
                name: "NomeTarefa",
                table: "Tarefas",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "DescricaoTarefa",
                keyValue: null,
                column: "DescricaoTarefa",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoTarefa",
                table: "Tarefas",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVencimentoTarefa",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "CodTarefa");
        }
    }
}
