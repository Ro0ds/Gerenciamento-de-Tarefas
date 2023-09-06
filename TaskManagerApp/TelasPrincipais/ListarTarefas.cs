using System.Data;
using TaskManagerApp.Enum;
using TaskManagerApp.Models;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class ListarTarefas : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public ListarTarefas()
        {
            InitializeComponent();

            ListarTarefasNoGrid();
        }

        public void ListarTarefasNoGrid()
        {
            var dados = _context.Tarefas.ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("CÓDIGO TAREFA", typeof(int));
            tabela.Columns.Add("USUÁRIO", typeof(string));
            tabela.Columns.Add("TAREFA", typeof(string));
            tabela.Columns.Add("DESCRIÇÃO", typeof(string));
            tabela.Columns.Add("VENCIMENTO", typeof(DateTime));
            tabela.Columns.Add("STATUS", typeof(string));
            tabela.Columns.Add("CRIADA EM", typeof(DateTime));

            foreach(var item in dados)
            {
                string situacaoTarefa = NormalizaSituacaoTarefa(item.SituacaoTarefa, item.DataVencimentoTarefa);

                tabela.Rows.Add(item.CodTarefa, TelaPrincipal.UsuarioConectado, item.NomeTarefa, item.DescricaoTarefa, item.DataVencimentoTarefa, situacaoTarefa, item.CriadaEm);
            }

            gridListarTarefas.DataSource = tabela;
        }

        public string NormalizaSituacaoTarefa(int situacaoTarefa, DateTime? dataVencimento)
        {
            string situacaoTarefaNormalizada = string.Empty;

            if(situacaoTarefa == (int)SituacaoTarefa.Finalizada || DateTime.Now >= dataVencimento)
            {
                situacaoTarefaNormalizada = "Finalizada";
            }
            else if(situacaoTarefa == (int)SituacaoTarefa.Criada)
            {
                situacaoTarefaNormalizada = "Criada";
            }
            else if(situacaoTarefa == (int)SituacaoTarefa.EmAndamento)
            {
                situacaoTarefaNormalizada = "Em andamento";
            }

            return situacaoTarefaNormalizada;
        }
    }
}