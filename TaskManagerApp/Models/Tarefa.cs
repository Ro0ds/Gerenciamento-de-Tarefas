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
        public Usuario? Usuario { get; set; }

        public Tarefa(int codTarefa, string nomeTarefa, string descricaoTarefa, DateTime dataVencimentoTarefa, int prioridadeTarefa, int situacaoTarefa)
        {
            CodTarefa = codTarefa;
            NomeTarefa = nomeTarefa;
            DescricaoTarefa = descricaoTarefa;
            DataVencimentoTarefa = dataVencimentoTarefa;
            PrioridadeTarefa = prioridadeTarefa;
            SituacaoTarefa = situacaoTarefa;
        }
    }
}