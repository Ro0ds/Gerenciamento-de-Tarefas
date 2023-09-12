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
            if (Formulario != null)
            {
                Formulario.Close();
            }
        }
    }
}
