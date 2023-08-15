﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManagerApp.Models;

#nullable disable

namespace TaskManagerApp.Migrations
{
    [DbContext(typeof(DbTaskmanagerContext))]
    [Migration("20230814224517_Mudança no tamanho das senhas")]
    partial class Mudançanotamanhodassenhas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("TaskManagerApp.Models.Usuario", b =>
                {
                    b.Property<int>("CodUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("COD_USUARIO");

                    b.Property<string>("DicaSenha")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DICA_SENHA");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NOME_COMPLETO");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NOME_USUARIO");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("SENHA_USUARIO");

                    b.HasKey("CodUsuario")
                        .HasName("PRIMARY");

                    b.ToTable("usuarios", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
