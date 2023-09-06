using TaskManagerApp.Entities;
using TaskManagerApp.Enum;
using TaskManagerApp.Models;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class CriarTarefas : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();
        string? Prioridade;

        public CriarTarefas()
        {
            InitializeComponent();
            txt_usuario.Text = TelaPrincipal.UsuarioConectado;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_nomeTarefa.Text) || string.IsNullOrEmpty(cb_prioridade.Text))
            {
                MessageBox.Show("Campos obrigatórios não preenchidos, verifique e tente novamente mais tarde", "Adicionar Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tarefa tarefa = new Tarefa(); // cria uma nova tarefa
                Tarefas tarefas = new Tarefas(); // cria a instancia da tarefa no banco de dados

                tarefa.NomeTarefa = txt_nomeTarefa.Text;
                tarefa.DescricaoTarefa = rctxt_descricao.Text;
                tarefa.DataVencimentoTarefa = dtp_dataVencimento.Value;
                tarefa.CriadaEm = DateTime.Now;

                Prioridade = cb_prioridade.Text;

                tarefa.PrioridadeTarefa = Prioridade switch
                {
                    "BaixaPrioridade" => (int)StatusTarefa.BaixaPrioridade,
                    "MediaPrioridade" => (int)StatusTarefa.MediaPrioridade,
                    "AltaPrioridade" => (int)StatusTarefa.AltaPrioridade,
                    _ => (int)StatusTarefa.BaixaPrioridade,
                };

                tarefa.SituacaoTarefa = (int)SituacaoTarefa.Criada;

                tarefa.CodUsuario = TelaPrincipal.CodUsuarioConectado;

                if(tarefas.AdicionarTarefa(tarefa))
                {
                    MessageBox.Show("Tarefa criada com sucesso!", "Adicionar tarefa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                LimparCampos();
            }
        }

        public void LimparCampos()
        {
            foreach(Control control in Controls)
            {
                foreach(Control campo in control.Controls)
                {
                    if((string)campo.Tag == "campoCriarTarefa")
                    {
                        campo.Text = string.Empty;
                    }
                }
            }
        }
    }
}