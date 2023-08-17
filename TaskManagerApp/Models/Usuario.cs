using System.ComponentModel.DataAnnotations;

namespace TaskManagerApp.Models;

public partial class Usuario
{
    public int CodUsuario { get; set; }

    public string NomeCompleto { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    public string EmailUsuario { set; get; } = null!;

    public string NomeUsuario { get; set; } = null!;

    public string SenhaUsuario { get; set; } = null!;

    public byte[] SaltSenhaUsuario { get; set; } = null!;

    public string? DicaSenha { get; set; }

    public string GrupoPermissao { get; set; } = "USUARIO";
}
