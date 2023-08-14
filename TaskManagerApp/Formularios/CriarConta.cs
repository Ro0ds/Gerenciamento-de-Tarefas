using TaskManagerApp.Models;
using TaskManagerApp.Entities;

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

            if(EstaPreenchidoCorretamente())
            {
                Usuario NovoUsuario = new Usuario();

                NovoUsuario.NomeCompleto = txt_nomeCompleto.Text;
                NovoUsuario.NomeUsuario = txt_usuario.Text;
                NovoUsuario.SenhaUsuario = txt_senha.Text;
                NovoUsuario.DicaSenha = txt_dicaSenha.Text;

                Usuarios Usuarios = new Usuarios();

                try
                {
                    Usuarios.AdicionarNovoUsuario(NovoUsuario);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar novo usuário: {ex.Message}", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
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

            foreach(Control painel in this.Controls)
            {
                foreach(Control campo in painel.Controls)
                {
                    if(campo is Label)
                    {
                        CamposNaoPreenchidos.Add(campo.Text.Replace(":", ""));
                    }

                    if((string)campo.Tag == "campoObrigatorio" && string.IsNullOrEmpty(campo.Text) || string.IsNullOrWhiteSpace(campo.Text))
                    {
                        statusDoPreenchimento = false;
                    }
                }
            }

            return statusDoPreenchimento;
        }
    }
}
