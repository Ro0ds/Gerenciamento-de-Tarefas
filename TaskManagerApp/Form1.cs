using System.Data;
using TaskManagerApp.TelasPrincipais;

namespace TaskManagerApp
{
    public partial class TelaPrincipal : Form
    {
        public Font FontPadrao { get; set; }
        public bool Selecionado { get; set; } = false;

        private Form? Formulario;

        public TelaPrincipal()
        {
            InitializeComponent();
            lbl_title.Text = "Painel Principal";

            // pegar fonte padrão das labels
            FontPadrao = lbl_menuPrincipal.Font;
        }

        #region Estilização
        public void MenuEstiloHover(Label label)
        {
            label.Font = new Font(FontPadrao, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.BackColor = Color.Black;
        }

        public void MenuEstiloLeave(Label label)
        {
            label.Font = FontPadrao;
            label.ForeColor = Color.Black;
            label.BackColor = Color.WhiteSmoke;
        }
        #endregion

        #region MouseHover
        private void lbl_menuPrincipal_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_menuPrincipal);
        }
        private void lbl_criarTarefa_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_criarTarefa);
        }

        private void lbl_listarTarefa_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_listarTarefa);
        }

        private void lbl_detalharTarefa_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_detalharTarefa);
        }

        private void lbl_editarTarefa_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_editarTarefa);
        }

        private void lbl_statusTarefa_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_statusTarefa);
        }

        private void lbl_configuracoes_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_configuracoes);
        }

        private void lbl_perfilUsuario_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_perfilUsuario);
        }
        #endregion

        #region MouseLeave
        private void lbl_menuPrincipal_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_menuPrincipal);
        }

        private void lbl_criarTarefa_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_criarTarefa);
        }

        private void lbl_listarTarefa_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_listarTarefa);
        }

        private void lbl_detalharTarefa_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_detalharTarefa);
        }

        private void lbl_editarTarefa_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_editarTarefa);
        }

        private void lbl_statusTarefa_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_statusTarefa);
        }

        private void lbl_configuracoes_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_configuracoes);
        }

        private void lbl_perfilUsuario_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_perfilUsuario);
        }
        #endregion

        #region MouseClick
        private void lbl_menuPrincipal_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new MenuPrincipal();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_criarTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new CriarTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_listarTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new ListarTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_detalharTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new DetalharTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_editarTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new EditarTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_statusTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new StatusTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_configuracoes_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new Configuracoes();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_perfilUsuario_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new PerfilUsuario();
            MostrarFormularioNaTela(Formulario);
        }
        #endregion

        public void MostrarFormularioNaTela(Form formulario)
        {
            formulario.IsAccessible = true;
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            this.painel.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
            lbl_title.Text = formulario.Name;
        }

        public void LiberaTela()
        {
            Formulario.Close();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            var forms = string.Join(',', Formulario.Name);
            MessageBox.Show($"Forms abertos: {Application.OpenForms.Count}\nForms: {forms}");
        }
    }
}