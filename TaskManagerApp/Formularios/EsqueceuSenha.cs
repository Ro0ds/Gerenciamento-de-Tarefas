using TaskManagerApp.Models;
using TaskManagerApp.Servicos;

namespace TaskManagerApp.Formularios
{
    public partial class EsqueceuSenha : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public EsqueceuSenha()
        {
            InitializeComponent();
            lbl_title.Text += "Recuperar Senha";
        }

        private void btn_enviarRecuperaSenha_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string email = txt_email.Text;

            if(UsuarioExiste(usuario, email))
            {
                Gmail gmail = new Gmail();

                gmail.EnviarEmail(email, "Recuperação de senha", "texto da recuperação de senha");
            }
        }

        private bool UsuarioExiste(string usuario, string email)
        {
            return _context.Usuarios.Any(u => u.NomeUsuario == usuario && u.EmailUsuario == email);
        }
    }
}