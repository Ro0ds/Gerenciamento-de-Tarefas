using System;
using System.Collections.Generic;

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
}
