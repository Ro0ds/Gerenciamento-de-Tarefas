using System;
using System.Collections.Generic;

namespace TaskManagerApp.Models;

public partial class Tarefa
{
    public int CodTarefa { get; set; }

    public int CodUsuario { get; set; }

    public string NomeTarefa { get; set; } = null!;

    public string? DescricaoTarefa { get; set; }

    public DateTime? DataVencimentoTarefa { get; set; }

    public int PrioridadeTarefa { get; set; }

    public int SituacaoTarefa { get; set; }

    public virtual Usuario CodUsuarioNavigation { get; set; } = null!;
}
