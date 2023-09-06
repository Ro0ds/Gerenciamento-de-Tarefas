using TaskManagerApp.TelasPrincipais;

namespace TaskManagerApp
{
    public partial class TelaPrincipal : Form
    {
        public static bool UsuarioAdministrativo { get; private set; } = false;
        public static string? UsuarioConectado { get; private set; }
        public static int CodUsuarioConectado { get; private set; }

        public Font FontPadrao { get; set; }
        public Font FontNegrito { get; set; }
        public Color CorBrancoFumaca { get; set; } = Color.WhiteSmoke;
        public Color CorPreta { get; set; } = Color.Black;

        private Form? Formulario;
        public int LarguraPadrao { get; } = 724;
        public int AlturaPadrao { get; } = 517;

        public TelaPrincipal()
        {
            InitializeComponent();
            lbl_title.Text = "Painel Principal";

            FontPadrao = lbl_menuPrincipal.Font;
            FontNegrito = new Font(FontPadrao, FontStyle.Bold);

            if(UsuarioAdministrativo)
            {
                lbl_administrador.Enabled = true;
                lbl_administrador.Visible = true;
            }
        }

        #region Estilização
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

        private void lbl_administrador_MouseHover(object sender, EventArgs e)
        {
            MenuEstiloHover(lbl_administrador);
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

        private void lbl_administrador_MouseLeave(object sender, EventArgs e)
        {
            MenuEstiloLeave(lbl_administrador);
        }
        #endregion

        #region MouseClick
        private void lbl_menuPrincipal_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new MenuPrincipal();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_criarTarefa_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new CriarTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_listarTarefa_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new ListarTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_editarTarefa_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new EditarTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_statusTarefa_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new StatusTarefas();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_configuracoes_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new Configuracoes();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_perfilUsuario_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new PerfilUsuario();
            MostrarFormularioNaTela(Formulario);
        }

        private void lbl_administrador_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new PainelAdministrador();
            MostrarFormularioNaTela(Formulario);
        }
        #endregion

        public void MostrarFormularioNaTela(Form formulario)
        {
            if(formulario.Name == "ListarTarefas")
            {
                this.Width = 1080;
                this.Height = AlturaPadrao;
            }
            else if(formulario.Name == "PainelAdministrador")
            {
                this.Width = 1080;
                this.Height = 720;
            }
            else
            {
                this.Width = LarguraPadrao;
                this.Height = AlturaPadrao;
            }

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
            if(Formulario != null)
            {
                Formulario.Close();
            }
        }

        // Debug - desativar depois
        private void lbl_title_Click(object sender, EventArgs e)
        {
            var forms = string.Join(',', Formulario.Name);
            MessageBox.Show($"Forms abertos: {Application.OpenForms.Count}\nForms: {forms}");
        }

        public static void UsuarioAdministrador(bool usuarioAdministrador)
        {
            UsuarioAdministrativo = usuarioAdministrador;
        }

        public static void InformacoesDeUsuario(string nome, int id)
        {
            UsuarioConectado = nome;
            CodUsuarioConectado = id;
        }
    }
}