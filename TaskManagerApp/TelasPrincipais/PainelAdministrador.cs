using TaskManagerApp.TelasAdministrador;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class PainelAdministrador : Form
    {
        private Form? Formulario;

        public PainelAdministrador()
        {
            InitializeComponent();
        }

        private void menuAdicionarUsuario_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new AdicionarUsuario();
            MostrarFormularioAdministrativo(Formulario);
        }

        private void menuEditarUsuario_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new EditarUsuario();
            MostrarFormularioAdministrativo(Formulario);
        }

        private void menuExcluirUsuario_Click(object sender, EventArgs e)
        {
            LiberaTela();

            Formulario = new ExcluirUsuario();
            MostrarFormularioAdministrativo(Formulario);
        }

        public void MostrarFormularioAdministrativo(Form formulario)
        {
            formulario.IsAccessible = true;
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            this.painelSecundario.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
        }

        public void LiberaTela()
        {
            if(Formulario != null)
            {
                Formulario.Close();
            }
        }
    }
}
