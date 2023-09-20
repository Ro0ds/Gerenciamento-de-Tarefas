using System.Data;
using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

namespace TaskManagerApp.TelasAdministrador
{
    public partial class EditarUsuario : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();
        private int CodUsuario { get; set; }

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
                        Usuario? usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.CodUsuario == CodUsuario);

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
            Usuario? usuarioOriginal = _context.Usuarios.FirstOrDefault(usuario => usuario.CodUsuario == CodUsuario);
            Usuario? usuarioModificado = MontarInformacoesDeUsuario(usuarioOriginal);

            if(QuantidadeDeMudancas(usuarioOriginal) > 0)
            {
                try
                {
                    _context.Entry(usuarioOriginal).State = EntityState.Detached;

                    _context.Usuarios.Update(usuarioModificado);
                    _context.SaveChanges();

                    MessageBox.Show("Usuário modificado com sucesso!", "Modificar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _context.Entry(usuarioModificado).State = EntityState.Detached;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Não foi possível modificar o usuário selecionado.\nErro:{ex.Message}", "Modificar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                txt_senha.Text = string.Empty;
                txt_dicaSenha.Text = usuario.DicaSenha;
                cb_grupoPermissao.Text = usuario.GrupoPermissao;
            }
        }

        private Usuario MontarInformacoesDeUsuario(Usuario usuarioNovo)
        {
            if(usuarioNovo != null)
            {
                usuarioNovo = new Usuario();
                Senhas senhas = new Senhas();

                usuarioNovo.CodUsuario = CodUsuario;
                usuarioNovo.NomeCompleto = txt_nomeCompleto.Text;
                usuarioNovo.NomeUsuario = txt_nomeUsuario.Text;
                usuarioNovo.EmailUsuario = txt_email.Text;
                usuarioNovo.DicaSenha = txt_dicaSenha.Text;
                usuarioNovo.GrupoPermissao = cb_grupoPermissao.Text;

                if(!string.IsNullOrEmpty(txt_senha.Text))
                {
                    usuarioNovo.SenhaUsuario = senhas.CriptografarSenha(txt_senha.Text, out byte[] salt);
                    usuarioNovo.SaltSenhaUsuario = salt;
                }

                if(ckb_status.CheckState == CheckState.Checked)
                {
                    usuarioNovo.UsuarioAtivo = true;
                }
                else if(ckb_status.CheckState == CheckState.Unchecked)
                {
                    usuarioNovo.UsuarioAtivo = false;
                }
            }

            return usuarioNovo;
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
