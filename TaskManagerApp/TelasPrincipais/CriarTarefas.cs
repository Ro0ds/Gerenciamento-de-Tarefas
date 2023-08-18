using TaskManagerApp.Models;

namespace TaskManagerApp.TelasPrincipais
{
    public partial class CriarTarefas : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public CriarTarefas()
        {
            InitializeComponent();
            txt_usuario.Text = TelaPrincipal.UsuarioConectado;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            
        }
    }
}