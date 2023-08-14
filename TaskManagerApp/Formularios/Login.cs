using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
