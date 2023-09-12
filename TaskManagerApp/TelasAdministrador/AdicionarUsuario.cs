using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

namespace TaskManagerApp.TelasAdministrador
{
    public partial class AdicionarUsuario : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public AdicionarUsuario()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(EstaPreenchidoCorretamente())
            {
                Usuario usuario = new Usuario();
                Senhas senhas = new Senhas();

                usuario.NomeCompleto = txt_nomeCompleto.Text;
                usuario.NomeUsuario = txt_nomeUsuario.Text;
                usuario.EmailUsuario = txt_email.Text;
                usuario.SenhaUsuario = senhas.CriptografarSenha(txt_senha.Text, out byte[] salt);
                usuario.SaltSenhaUsuario = salt;
                usuario.DicaSenha = txt_dicaSenha.Text;
                usuario.GrupoPermissao = cb_grupoPermissao.Text.ToUpper();

                if(cb_grupoPermissao.Text != "ADMINISTRADOR" && cb_grupoPermissao.Text != "USUARIO")
                {
                    MessageBox.Show("Grupo permissão preenchido incorretamente, por favor, selecione uma opção válida", "Grupo permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _context.Usuarios.Add(usuario);
                        _context.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Erro ao adicionar usuário.\nErro: {ex.Message}", "Adicionar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Usuário adicionado com sucesso!", "Adicionar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Campos preenchidos incorretamente, tente novamente.", "Adicionar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool EstaPreenchidoCorretamente()
        {
            foreach(Control control in Controls)
            {
                if((string)control.Tag == "campoObrigatorio")
                {
                    if(string.IsNullOrEmpty(control.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
