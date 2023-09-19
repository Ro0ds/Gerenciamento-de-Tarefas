using System.Data;
using TaskManagerApp.Enum;
using TaskManagerApp.Models;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class EditarTarefas : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public EditarTarefas()
        {
            InitializeComponent();
            ListarTarefasNoGrid();
        }

        public void ListarTarefasNoGrid()
        {
            var tarefas = _context.Tarefas.ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("CÓDIGO TAREFA", typeof(int));
            tabela.Columns.Add("NOME TAREFA", typeof(string));
            tabela.Columns.Add("STATUS", typeof(string));

            foreach(Tarefa tarefa in tarefas)
            {
                if(tarefa.CodUsuario == TelaPrincipal.CodUsuarioConectado)
                {
                    string situacaoTarefa = ListarTarefas.NormalizaSituacaoTarefa(tarefa.SituacaoTarefa, tarefa.DataVencimentoTarefa);

                    tabela.Rows.Add(tarefa.CodTarefa, tarefa.NomeTarefa, situacaoTarefa);
                }
            }

            gridTarefas.DataSource = tabela;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int CodTarefa = 0;

            try
            {
                CodTarefa = int.Parse(txt_codTarefa.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Campo apenas numérico.\nErro: {ex.Message}", "Código da tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PreencherCampos(CodTarefa);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void PreencherCampos(int codigoTarefa)
        {
            if(codigoTarefa == 0)
            {
                MessageBox.Show($"Entre com um valor maior que zero.", "Código da tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HabilitaCampos();
                Tarefa? tarefa = _context.Tarefas.Where(c => c.CodTarefa == codigoTarefa).FirstOrDefault();

                txt_nomeTarefa.Text = tarefa.NomeTarefa;
                rctxt_descricao.Text = tarefa.DescricaoTarefa;
                dt_termina.Value = (DateTime)tarefa.DataVencimentoTarefa;
                int Prioridade = _context.Tarefas.Where(u => u.CodTarefa == codigoTarefa).Select(u => u.PrioridadeTarefa).FirstOrDefault();

                switch(Prioridade)
                {
                    case 10:
                        cb_prioridade.Text = "BaixaPrioridade";
                        break;
                    case 50:
                        cb_prioridade.Text = "MediaPrioridade";
                        break;
                    case 100:
                        cb_prioridade.Text = "AltaPrioridade";
                        break;
                }

                cb_status.Text = ListarTarefas.NormalizaSituacaoTarefa(tarefa.SituacaoTarefa, tarefa.DataVencimentoTarefa);
                dt_criada.Value = (DateTime)tarefa.CriadaEm;
            }
        }

        private void HabilitaCampos()
        {
            foreach(Control control in Controls)
            {
                if((string)control.Tag == "camposEdicao")
                {
                    control.Enabled = true;
                    txt_codTarefa.Enabled = false;
                }
            }
        }
    }
}
