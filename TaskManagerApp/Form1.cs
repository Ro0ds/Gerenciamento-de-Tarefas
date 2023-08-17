using System.Data;
using TaskManagerApp.TelasPrincipais;

namespace TaskManagerApp
{
    public partial class TelaPrincipal : Form
    {
        public Font FontPadrao { get; set; }
        public Font FontNegrito { get; set; }
        public Color CorBrancoFumaca { get; set; } = Color.WhiteSmoke;
        public Color CorPreta { get; set; } = Color.Black;

        private Form? Formulario;
        private Label? Label;

        public (Form _formulario, Label _label, bool _bool) EstaEstilizado;

        public TelaPrincipal()
        {
            InitializeComponent();
            lbl_title.Text = "Painel Principal";

            FontPadrao = lbl_menuPrincipal.Font;
            FontNegrito = new Font(FontPadrao, FontStyle.Bold);

            EstaEstilizado._formulario = Formulario;
            EstaEstilizado._label = Label;
            EstaEstilizado._bool = true;
        }

        #region Estilização
        public void MenuSelecionado(Label label)
        {
            label.Font = FontNegrito;
            label.ForeColor = CorBrancoFumaca;
            label.BackColor = CorPreta;
        }

        public void MenuEstiloHover(Label label)
        {
            label.Font = FontPadrao;
            label.ForeColor = CorBrancoFumaca;
            label.BackColor = CorPreta;
        }

        public void MenuEstiloLeave(Label label)
        {
            label.Font = FontPadrao;
            label.ForeColor = CorPreta;
            label.BackColor = CorBrancoFumaca;
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
            if(EstaEstilizado._bool == false && EstaEstilizado._label != null)
            {
                MenuEstiloLeave(lbl_menuPrincipal);
            }
            else if(EstaEstilizado._formulario == Formulario && EstaEstilizado._label == Label && EstaEstilizado._bool == true)
            {
                AtualizarSelecionado(EstaEstilizado._label);
            }

            MessageBox.Show(EstaEstilizado.GetType().ToString());
        }

        private void lbl_criarTarefa_MouseLeave(object sender, EventArgs e)
        {
            if(EstaEstilizado._bool == false && EstaEstilizado._label != null)
            {
                MenuEstiloLeave(lbl_criarTarefa);
            }
            else if(EstaEstilizado._formulario == Formulario && EstaEstilizado._label == Label && EstaEstilizado._bool == true)
            {
                AtualizarSelecionado(EstaEstilizado._label);
            }
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

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_criarTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new CriarTarefas();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_listarTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new ListarTarefas();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_detalharTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new DetalharTarefas();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_editarTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new EditarTarefas();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_statusTarefa_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new StatusTarefas();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_configuracoes_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new Configuracoes();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
        }

        private void lbl_perfilUsuario_Click(object sender, EventArgs e)
        {
            if(Formulario != null)
            {
                LiberaTela();
            }

            Formulario = new PerfilUsuario();
            MostrarFormularioNaTela(Formulario);

            Label = (Label)sender;
            AtualizarSelecionado(Label);
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

        public void RetirarEstiloDosMenus()
        {
            foreach(Control painel in Controls)
            {
                foreach(Control label in painel.Controls)
                {
                    if(label is Label && (string)label.Tag == "menu")
                    {
                        label.Font = FontPadrao;
                        label.ForeColor = CorPreta;
                        label.BackColor = CorBrancoFumaca;
                    }
                }
            }
        }

        public void AtualizarSelecionado(Label nomeMenu)
        {
            RetirarEstiloDosMenus();

            if(Formulario.Name == lbl_title.Text)
            {
                MenuSelecionado(nomeMenu);
            }
        }

        // Debug - desativar depois
        private void lbl_title_Click(object sender, EventArgs e)
        {
            var forms = string.Join(',', Formulario.Name);
            MessageBox.Show($"Forms abertos: {Application.OpenForms.Count}\nForms: {forms}");
        }
    }
}