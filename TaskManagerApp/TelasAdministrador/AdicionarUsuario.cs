namespace TaskManagerApp.TelasAdministrador
{
    public partial class AdicionarUsuario : Form
    {
        public AdicionarUsuario()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.Size.Width};{this.Size.Height}");
        }
    }
}
