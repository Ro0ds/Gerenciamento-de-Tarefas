using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

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

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string email = txt_email.Text;

            if(UsuarioExiste(usuario, email))
            {
                lbl_senha.Visible = true;
                lbl_novamente.Visible = true;
                txt_novaSenha.Visible = true;
                txt_senhaNovamente.Visible = true;

                MessageBox.Show("Usuário localizado!", "Resetar senha", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_email.Enabled = false;
                txt_usuario.Enabled = false;
            }
        }

        private void btn_resetaSenha_Click(object sender, EventArgs e)
        {
            Senhas senhas = new Senhas();

            if(txt_novaSenha.Text == txt_senhaNovamente.Text)
            {
                senhas.RegistraSenha(txt_novaSenha.Text);
                string HashSenha = senhas.CriptografarSenha(txt_novaSenha.Text, out byte[] salt);

                int CodUsuario = PegarIdUsuario(txt_usuario.Text, txt_email.Text);

                Usuario? usuario = _context.Usuarios.Where(u => u.CodUsuario == CodUsuario).FirstOrDefault();
                usuario.SenhaUsuario = HashSenha;
                usuario.SaltSenhaUsuario = salt;

                try
                {
                    _context.Update(usuario);
                    _context.SaveChanges();

                    MessageBox.Show("Senha alterada com sucesso!", "Resetar senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Não foi possível alterar a senha.\nErro: {ex.Message}!", "Resetar senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int PegarIdUsuario(string usuario, string email)
        {
            return _context.Usuarios.Where(u => u.EmailUsuario == email && u.NomeUsuario == usuario).Select(u => u.CodUsuario).FirstOrDefault();
        }

        private bool UsuarioExiste(string usuario, string email)
        {
            return _context.Usuarios.Any(u => u.NomeUsuario == usuario && u.EmailUsuario == email);
        }
    }
}