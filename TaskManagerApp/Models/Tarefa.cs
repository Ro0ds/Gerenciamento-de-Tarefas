using System.ComponentModel.DataAnnotations;

namespace TaskManagerApp.Models
{
    public partial class Tarefa
    {
        [Key]
        public int CodTarefa { get; set; }

        [Required]
        public string NomeTarefa { get; set; }
        public string DescricaoTarefa { get; set; }

        [Required]
        public DateTime DataVencimentoTarefa { get; set; }
        public int PrioridadeTarefa { get; set; }
        public int SituacaoTarefa { get; set; }
        public int CodUsuario { get; set; }

        public Tarefa() { }
        public Tarefa(string nomeTarefa, string descricaoTarefa, DateTime dataVencimentoTarefa, int prioridadeTarefa, int situacaoTarefa)
        {
            NomeTarefa = nomeTarefa;
            DescricaoTarefa = descricaoTarefa;
            DataVencimentoTarefa = dataVencimentoTarefa;
            PrioridadeTarefa = prioridadeTarefa;
            SituacaoTarefa = situacaoTarefa;
        }
    }
}