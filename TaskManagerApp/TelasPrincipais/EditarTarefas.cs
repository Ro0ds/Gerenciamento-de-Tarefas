using System.Data;
using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class EditarTarefas : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();
        private Tarefa TarefaOriginal;
        private int CodTarefa = 0;

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
            if(CampoNumerico(txt_codTarefa.Text))
            {
                PreencherCampos(CodTarefa, TelaPrincipal.CodUsuarioConectado);
            }
        }

        private void txt_codTarefa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && CampoNumerico(txt_codTarefa.Text))
            {
                PreencherCampos(CodTarefa, TelaPrincipal.CodUsuarioConectado);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if(ExisteCampoVazio())
            {
                MessageBox.Show("Existe campo vazio, revise novamente a tarefa.", "Editar Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Tarefa TarefaEditada = PegarCamposEditados();

                try
                {
                    _context.Entry(TarefaOriginal).State = EntityState.Detached;

                    _context.Tarefas.Update(TarefaEditada);
                    _context.SaveChanges();

                    MessageBox.Show("Tarefa editada com sucesso!.", "Editar Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarTarefasNoGrid();

                    _context.Entry(TarefaEditada).State = EntityState.Detached;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Não foi possível editar a tarefa.\nErro: {ex.Message}", "Editar Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CampoNumerico(string numero)
        {
            try
            {
                CodTarefa = int.Parse(txt_codTarefa.Text);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Campo apenas numérico.\nErro: {ex.Message}", "Código da tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PreencherCampos(int codigoTarefa, int codigoUsuario)
        {
            if(codigoTarefa == 0)
            {
                MessageBox.Show($"Entre com um valor maior que zero.", "Código da tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TarefaOriginal = _context.Tarefas.Where(c => c.CodTarefa == codigoTarefa && c.CodUsuario == codigoUsuario).FirstOrDefault();

                if(TarefaOriginal != null)
                {
                    HabilitaCampos();

                    txt_nomeTarefa.Text = TarefaOriginal.NomeTarefa;
                    rctxt_descricao.Text = TarefaOriginal.DescricaoTarefa;
                    dt_termina.Value = (DateTime)TarefaOriginal.DataVencimentoTarefa;
                    int Prioridade = _context.Tarefas.Where(u => u.CodTarefa == codigoTarefa).Select(u => u.PrioridadeTarefa).FirstOrDefault();

                    cb_prioridade.Text = NormalizaPrioridade(Prioridade);

                    //switch(Prioridade)
                    //{
                    //    case 10:
                    //        cb_prioridade.Text = "BaixaPrioridade";
                    //        break;
                    //    case 50:
                    //        cb_prioridade.Text = "MediaPrioridade";
                    //        break;
                    //    case 100:
                    //        cb_prioridade.Text = "AltaPrioridade";
                    //        break;
                    //}

                    cb_status.Text = ListarTarefas.NormalizaSituacaoTarefa(TarefaOriginal.SituacaoTarefa, TarefaOriginal.DataVencimentoTarefa);
                    dt_criada.Value = (DateTime)TarefaOriginal.CriadaEm;
                }
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

        private bool ExisteCampoVazio()
        {
            int camposVazios = 0;

            foreach(Control control in Controls)
            {
                if((string)control.Tag == "camposEdicao")
                {
                    if(string.IsNullOrEmpty(control.Text))
                    {
                        camposVazios++;
                    }
                }
            }

            return camposVazios > 0;
        }

        private Tarefa PegarCamposEditados()
        {
            return _ = new Tarefa
            {
                CodTarefa = CodTarefa,
                CodUsuario = TelaPrincipal.CodUsuarioConectado,
                NomeTarefa = txt_nomeTarefa.Text,
                DescricaoTarefa = rctxt_descricao.Text,
                DataVencimentoTarefa = dt_termina.Value,
                PrioridadeTarefa = NormalizaPrioridade(cb_prioridade.Text),
                SituacaoTarefa = NormalizaStatus(cb_status.Text),
                CriadaEm = dt_criada.Value
            };
        }

        public static int NormalizaPrioridade(string prioridade)
        {
            switch (prioridade)
            {
                case "BaixaPrioridade":
                    return 10;
                case "MediaPrioridade":
                    return 50;
                case "AltaPrioridade":
                    return 100;
                default:
                    return 10;
            }
        }

        public static string NormalizaPrioridade(int prioridade)
        {
            switch(prioridade)
            {
                case 10:
                    return "BaixaPrioridade";
                case 50:
                    return "MediaPrioridade";
                case 100:
                    return "AltaPrioridade";
                default:
                    return "BaixaPrioridade";
            }
        }

        private int NormalizaStatus(string status)
        {
            switch (status)
            {
                case "Criada":
                    return 1;
                case "EmAndamento":
                    return 2;
                case "Finalizada":
                    return 3;
                default:
                    return 1;
            }
        }
    }
}
