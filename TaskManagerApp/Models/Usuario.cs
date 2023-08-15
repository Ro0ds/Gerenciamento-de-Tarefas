namespace TaskManagerApp.Models;

public partial class Usuario
{
    public int CodUsuario { get; set; }

    public string NomeCompleto { get; set; } = null!;

    public string NomeUsuario { get; set; } = null!;

    public string SenhaUsuario { get; set; } = null!;

    public byte[] SaltSenhaUsuario { get; set; } = null!;

    public string? DicaSenha { get; set; }
}
