using TaskManagerApp.Entities;

namespace TaskManagerApp.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lbl_title.Text += "Login";
        }

        private void llbl_criarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CriarConta criarConta = new CriarConta();
            criarConta.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            if (usuarios.LogarUsuario(txt_usuario.Text, txt_senha.Text))
            {
                TelaPrincipal principal = new TelaPrincipal();
                Hide();
                principal.ShowDialog();
                Close();
            }
            else
            {
                this.ActiveControl = txt_usuario;
            }
        }

        private void llbl_recuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}