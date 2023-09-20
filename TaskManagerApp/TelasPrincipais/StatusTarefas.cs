using System.Data;
using TaskManagerApp.Enum;
using TaskManagerApp.Models;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class StatusTarefas : Form
    {
        private readonly DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public StatusTarefas()
        {
            InitializeComponent();
            PreencheGridComTarefas();
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            FiltroPrioridade();
        }

        private void PreencheGridComTarefas()
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("NOME TAREFA", typeof(string));
            tabela.Columns.Add("DESCRIÇÃO TAREFA", typeof(string));
            tabela.Columns.Add("PRIORIDADE", typeof(string));
            tabela.Columns.Add("STATUS", typeof(string));
            tabela.Columns.Add("VENCIMENTO", typeof(DateTime));

            var tarefas = _context.Tarefas.Where(t => t.CodUsuario == TelaPrincipal.CodUsuarioConectado);

            if(tarefas.Any())
            {
                foreach(Tarefa item in tarefas)
                {
                    string situacaoTarefa = ListarTarefas.NormalizaSituacaoTarefa(item.SituacaoTarefa, item.DataVencimentoTarefa);
                    string prioridade = EditarTarefas.NormalizaPrioridade(item.PrioridadeTarefa);

                    tabela.Rows.Add(item.NomeTarefa, item.DescricaoTarefa, prioridade, situacaoTarefa, item.DataVencimentoTarefa);
                }

                gridStatusTarefas.DataSource = tabela;
            }
            else
            {
                MessageBox.Show("Usuário não possui tarefas.", "Status Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private int FiltroPrioridade()
        {
            foreach(RadioButton opcao in grupoPrioridade.Controls)
            {
                if(opcao.Checked)
                {
                    return EditarTarefas.NormalizaPrioridade((string)opcao.Tag);
                }
            }

            return 0;
        }

        private int FiltroStatus()
        {
            foreach(RadioButton opcao in grupoStatus.Controls)
            {
                if(opcao.Checked)
                {
                    return NormalizaSituacaoTarefa((string)opcao.Tag);
                }
            }

            return 0;
        }

        private int NormalizaSituacaoTarefa(string situacaoTarefa)
        {
            switch(situacaoTarefa)
            {
                case "Criado":
                    return (int)SituacaoTarefa.Criada;
                case "EmAndamento":
                    return (int)SituacaoTarefa.EmAndamento;
                case "Finalizada":
                    return (int)SituacaoTarefa.Finalizada;
                default:
                    return (int)SituacaoTarefa.Finalizada;
            }
        }
    }
}