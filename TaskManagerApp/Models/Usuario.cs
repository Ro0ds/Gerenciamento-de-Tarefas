namespace TaskManagerApp.Models;

public partial class Usuario
{
    public int CodUsuario { get; set; }

    public string NomeCompleto { get; set; } = null!;

    public string NomeUsuario { get; set; } = null!;

    public string? EmailUsuario { get; set; }

    public string SenhaUsuario { get; set; } = null!;

    public byte[]? SaltSenhaUsuario { get; set; }

    public string? DicaSenha { get; set; }

    public string? GrupoPermissao { get; set; }

    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

    public Usuario() { }

    public Usuario(Usuario outroUsuario)
    {
        this.NomeCompleto = outroUsuario.NomeCompleto;
        this.NomeUsuario = outroUsuario.NomeUsuario;
        this.EmailUsuario = outroUsuario.EmailUsuario;
        this.SenhaUsuario = outroUsuario.SenhaUsuario;
        this.SaltSenhaUsuario = outroUsuario.SaltSenhaUsuario;
        this.DicaSenha = outroUsuario.DicaSenha;
        this.GrupoPermissao = outroUsuario.GrupoPermissao;
    }
}
