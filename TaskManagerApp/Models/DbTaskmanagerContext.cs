using Microsoft.EntityFrameworkCore;

namespace TaskManagerApp.Models;

public partial class DbTaskmanagerContext : DbContext
{
    public DbTaskmanagerContext() { }

    public DbTaskmanagerContext(DbContextOptions<DbTaskmanagerContext> options)
        : base(options) { }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=DB_TASKMANAGER;uid=developer;pwd=Acesso@123", ServerVersion.Parse("8.0.23-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Usuario>(entity => {
            entity.HasIndex(e => e.NomeUsuario).IsUnique();
        });

        modelBuilder.Entity<Usuario>(entity => {
            entity.HasKey(e => e.CodUsuario).HasName("PRIMARY");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.CodUsuario)
                .HasColumnName("COD_USUARIO");

            entity.Property(e => e.NomeCompleto)
                .HasMaxLength(50)
                .HasColumnName("NOME_COMPLETO");

            entity.Property(e => e.EmailUsuario)
                .HasMaxLength(70)
                .HasColumnName("EMAIL_USUARIO");

            entity.Property(e => e.NomeUsuario)
                .HasMaxLength(100)
                .HasColumnName("NOME_USUARIO");

            entity.Property(e => e.SenhaUsuario)
                .HasMaxLength(250)
                .HasColumnName("SENHA_USUARIO");

            entity.Property(e => e.SaltSenhaUsuario)
                .HasMaxLength(250)
                .HasColumnName("SALT_SENHA_USUARIO");

            entity.Property(e => e.DicaSenha)
                .HasMaxLength(100)
                .HasColumnName("DICA_SENHA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
