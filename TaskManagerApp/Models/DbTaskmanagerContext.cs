using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskManagerApp.Models;

public partial class DbTaskmanagerContext : DbContext
{
    public DbTaskmanagerContext()
    {
    }

    public DbTaskmanagerContext(DbContextOptions<DbTaskmanagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarefa> Tarefas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=DB_TASKMANAGER;uid=developer;pwd=Acesso@123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Tarefa>(entity =>
        {
            entity.HasKey(e => e.CodTarefa).HasName("PRIMARY");

            entity.ToTable("tarefas");

            entity.HasIndex(e => e.CodUsuario, "COD_USUARIO");

            entity.Property(e => e.CodTarefa).HasColumnName("COD_TAREFA");
            entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");
            entity.Property(e => e.CriadaEm)
                .HasMaxLength(6)
                .HasColumnName("CRIADA_EM");
            entity.Property(e => e.DataVencimentoTarefa)
                .HasMaxLength(6)
                .HasColumnName("DATA_VENCIMENTO_TAREFA");
            entity.Property(e => e.DescricaoTarefa)
                .HasMaxLength(250)
                .HasColumnName("DESCRICAO_TAREFA");
            entity.Property(e => e.NomeTarefa)
                .HasMaxLength(50)
                .HasColumnName("NOME_TAREFA");
            entity.Property(e => e.PrioridadeTarefa)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRIORIDADE_TAREFA");
            entity.Property(e => e.SituacaoTarefa)
                .HasDefaultValueSql("'1'")
                .HasColumnName("SITUACAO_TAREFA");

            entity.HasOne(d => d.CodUsuarioNavigation).WithMany(p => p.Tarefas)
                .HasForeignKey(d => d.CodUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tarefas_ibfk_1");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.CodUsuario).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.NomeUsuario, "NOME_USUARIO").IsUnique();

            entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");
            entity.Property(e => e.DicaSenha)
                .HasMaxLength(50)
                .HasColumnName("DICA_SENHA");
            entity.Property(e => e.EmailUsuario)
                .HasMaxLength(50)
                .HasColumnName("EMAIL_USUARIO");
            entity.Property(e => e.GrupoPermissao)
                .HasMaxLength(15)
                .HasDefaultValueSql("'USUARIO'")
                .HasColumnName("GRUPO_PERMISSAO");
            entity.Property(e => e.NomeCompleto)
                .HasMaxLength(50)
                .HasColumnName("NOME_COMPLETO");
            entity.Property(e => e.NomeUsuario)
                .HasMaxLength(50)
                .HasColumnName("NOME_USUARIO");
            entity.Property(e => e.SaltSenhaUsuario)
                .HasMaxLength(255)
                .HasColumnName("SALT_SENHA_USUARIO");
            entity.Property(e => e.SenhaUsuario)
                .HasMaxLength(255)
                .HasColumnName("SENHA_USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
