using System.Data;
using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

namespace TaskManagerApp.TelasAdministrador
{
    public partial class EditarUsuario : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();
        private int CodUsuario { get; set; }
        private Usuario? usuario { get; set; }

        public EditarUsuario()
        {
            InitializeComponent();
            ListarUsuariosNoGrid();
        }

        private void ListarUsuariosNoGrid()
        {
            List<Usuario> usuarios = _context.Usuarios.ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("CÓDIGO USUÁRIO", typeof(int));
            tabela.Columns.Add("NOME USUÁRIO", typeof(string));

            foreach(Usuario usuario in usuarios)
            {
                tabela.Rows.Add(usuario.CodUsuario, usuario.NomeUsuario);
            }

            gridUsuarios.DataSource = tabela;
        }

        private void txt_codUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            List<int> codigos = _context.Usuarios.Select(usuario => usuario.CodUsuario).ToList();

            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if(int.TryParse(txt_codUsuario.Text, out int value))
                {
                    CodUsuario = int.Parse(txt_codUsuario.Text);

                    if(codigos.Contains(CodUsuario))
                    {
                        usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.CodUsuario == CodUsuario);

                        PreencheCampos(usuario);
                        HabilitaCampos();
                    }
                    else
                    {
                        MessageBox.Show("Código não encontrado", "Editar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_mudar_Click(object sender, EventArgs e)
        {
            txt_codUsuario.Enabled = true;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Usuario? usuarioOriginal = usuario;
            Usuario? usuarioModificado = new Usuario(MontarInformacoesDeUsuario(usuarioOriginal));
            
            if(QuantidadeDeMudancas(usuarioModificado) > 0)
            {
                try
                {
                    _context.Usuarios.Update(usuarioModificado);
                    _context.SaveChanges();

                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Não foi possível modificar o usuário selecionado.\nErro:{ex.Message}", "Modificar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Usuário modificado com sucesso!", "Modificar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não houve mudanças, usuário não modificado.", "Modificar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PreencheCampos(Usuario usuario)
        {
            if(usuario != null)
            {
                txt_nomeCompleto.Text = usuario.NomeCompleto;
                txt_nomeUsuario.Text = usuario.NomeUsuario;
                txt_email.Text = usuario.EmailUsuario;
                txt_senha.Text = usuario.SenhaUsuario;
                txt_dicaSenha.Text = usuario.DicaSenha;
                cb_grupoPermissao.Text = usuario.GrupoPermissao;
            }
        }

        private Usuario MontarInformacoesDeUsuario(Usuario usuario)
        {
            if(usuario != null)
            {
                Senhas senhas = new Senhas();

                usuario.NomeCompleto = txt_nomeCompleto.Text;
                usuario.NomeUsuario = txt_nomeUsuario.Text;
                usuario.EmailUsuario = txt_email.Text;
                usuario.DicaSenha = txt_dicaSenha.Text;
                usuario.GrupoPermissao = cb_grupoPermissao.Text;

                if(usuario.SenhaUsuario != txt_senha.Text)
                {
                    usuario.SenhaUsuario = senhas.CriptografarSenha(txt_senha.Text, out byte[] salt);
                    usuario.SaltSenhaUsuario = salt;
                }
            }

            return usuario;
        }

        private int QuantidadeDeMudancas(Usuario usuario)
        {
            int mudancas = 0;

            if(txt_nomeCompleto.Text != usuario.NomeCompleto)
            {
                mudancas++;
            }
            else if(txt_nomeUsuario.Text != usuario.NomeUsuario)
            {
                mudancas++;
            }
            else if(txt_email.Text != usuario.EmailUsuario)
            {
                mudancas++;
            }
            else if(txt_senha.Text != usuario.SenhaUsuario)
            {
                mudancas++;
            }
            else if(txt_dicaSenha.Text != usuario.DicaSenha)
            {
                mudancas++;
            }
            else if(cb_grupoPermissao.Text != usuario.GrupoPermissao)
            {
                mudancas++;
            }

            return mudancas;
        }

        private void HabilitaCampos()
        {
            foreach(Control control in Controls)
            {
                if((string)control.Tag == "usuario")
                {
                    control.Enabled = true;
                }

                if((string)control.Tag == "codUsuario")
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
