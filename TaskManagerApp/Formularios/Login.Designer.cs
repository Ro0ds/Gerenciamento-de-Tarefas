namespace TaskManagerApp.Formularios
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_title = new Label();
            label1 = new Label();
            txt_usuario = new TextBox();
            btn_entrar = new Button();
            llbl_criarConta = new LinkLabel();
            txt_senha = new TextBox();
            label2 = new Label();
            llbl_recuperarSenha = new LinkLabel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.Dock = DockStyle.Top;
            lbl_title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(0, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(446, 44);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "TaskManagerApp - ";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(94, 15);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 29);
            txt_usuario.TabIndex = 1;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(17, 85);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(177, 23);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // llbl_criarConta
            // 
            llbl_criarConta.AutoSize = true;
            llbl_criarConta.LinkColor = Color.FromArgb(128, 128, 255);
            llbl_criarConta.Location = new Point(21, 111);
            llbl_criarConta.Name = "llbl_criarConta";
            llbl_criarConta.Size = new Size(65, 15);
            llbl_criarConta.TabIndex = 4;
            llbl_criarConta.TabStop = true;
            llbl_criarConta.Text = "Criar conta";
            llbl_criarConta.LinkClicked += llbl_criarConta_LinkClicked;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(94, 50);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(100, 29);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 54);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // llbl_recuperarSenha
            // 
            llbl_recuperarSenha.AutoSize = true;
            llbl_recuperarSenha.LinkColor = Color.FromArgb(128, 128, 255);
            llbl_recuperarSenha.Location = new Point(102, 111);
            llbl_recuperarSenha.Name = "llbl_recuperarSenha";
            llbl_recuperarSenha.Size = new Size(94, 15);
            llbl_recuperarSenha.TabIndex = 5;
            llbl_recuperarSenha.TabStop = true;
            llbl_recuperarSenha.Text = "Recuperar senha";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(llbl_recuperarSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(btn_entrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(llbl_criarConta);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(119, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 144);
            panel1.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(446, 243);
            Controls.Add(panel1);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_title;
        private Label label1;
        private TextBox txt_usuario;
        private Button btn_entrar;
        private LinkLabel llbl_criarConta;
        private TextBox txt_senha;
        private Label label2;
        private LinkLabel llbl_recuperarSenha;
        private Panel panel1;
    }
}