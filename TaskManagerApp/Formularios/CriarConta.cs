using TaskManagerApp.Models;
using TaskManagerApp.Entities;
using TaskManagerApp.Seguranca;
using Microsoft.EntityFrameworkCore;

namespace TaskManagerApp.Formularios
{
    public partial class CriarConta : Form
    {
        public List<string> CamposNaoPreenchidos { get; set; } = new List<string>();

        public CriarConta()
        {
            InitializeComponent();
            lbl_title.Text += "Criar Conta";
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            CamposNaoPreenchidos.Clear();

            if (EstaPreenchidoCorretamente())
            {
                Usuario NovoUsuario = new Usuario();
                Senhas criptografia = new Senhas();

                // Segurança da senha
                criptografia.RegistraSenha(txt_senha.Text);
                string SenhaCriptografada = criptografia.CriptografarSenha(txt_senha.Text, out var salt);

                NovoUsuario.NomeCompleto = txt_nomeCompleto.Text;
                NovoUsuario.NomeUsuario = txt_usuario.Text;
                NovoUsuario.SenhaUsuario = SenhaCriptografada;
                NovoUsuario.SaltSenhaUsuario = salt;
                NovoUsuario.DicaSenha = txt_dicaSenha.Text;

                Usuarios Usuarios = new Usuarios();

                try
                {
                    Usuarios.AdicionarNovoUsuario(NovoUsuario);
                }
                catch (DbUpdateException dbex)
                {
                    throw new DbUpdateException($"Erro ao adicionar novo usuário: {dbex.Message}. Usuário já existe");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao adicionar novo usuário: {ex.Message}");
                }

                DialogResult resultado = MessageBox.Show($"Usuário: {NovoUsuario.NomeUsuario} criado com sucesso, deseja voltar a tela de login?", "Usuário criado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                var camposNaoPreenchidos = string.Join(Environment.NewLine, CamposNaoPreenchidos);

                MessageBox.Show($"Campos não preenchidos corretamente, tente novamente.\n\nCampos que estão faltando:\n{camposNaoPreenchidos}", "Preenchimento incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool EstaPreenchidoCorretamente()
        {
            bool statusDoPreenchimento = true;

            // TODO: arrumar essa verificação de campos em branco depois
            foreach (Control painel in this.Controls)
            {
                foreach (Control campo in painel.Controls)
                {
                    if (campo is Label)
                    {
                        CamposNaoPreenchidos.Add(campo.Text.Replace(":", ""));
                    }

                    if ((string)campo.Tag == "campoObrigatorio" && string.IsNullOrEmpty(campo.Text) || string.IsNullOrWhiteSpace(campo.Text))
                    {
                        statusDoPreenchimento = false;
                    }
                }
            }

            return statusDoPreenchimento;
        }
    }
}
