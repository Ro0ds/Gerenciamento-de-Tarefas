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
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.llbl_criarConta = new System.Windows.Forms.LinkLabel();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llbl_recuperarSenha = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(446, 44);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "TaskManagerApp - ";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(94, 15);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Nome de usuário";
            this.txt_usuario.Size = new System.Drawing.Size(307, 29);
            this.txt_usuario.TabIndex = 1;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(17, 85);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(384, 23);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // llbl_criarConta
            // 
            this.llbl_criarConta.AutoSize = true;
            this.llbl_criarConta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llbl_criarConta.Location = new System.Drawing.Point(17, 111);
            this.llbl_criarConta.Name = "llbl_criarConta";
            this.llbl_criarConta.Size = new System.Drawing.Size(65, 15);
            this.llbl_criarConta.TabIndex = 4;
            this.llbl_criarConta.TabStop = true;
            this.llbl_criarConta.Text = "Criar conta";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.Location = new System.Drawing.Point(94, 50);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PlaceholderText = "Senha";
            this.txt_senha.Size = new System.Drawing.Size(307, 29);
            this.txt_senha.TabIndex = 2;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llbl_recuperarSenha
            // 
            this.llbl_recuperarSenha.AutoSize = true;
            this.llbl_recuperarSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llbl_recuperarSenha.Location = new System.Drawing.Point(307, 111);
            this.llbl_recuperarSenha.Name = "llbl_recuperarSenha";
            this.llbl_recuperarSenha.Size = new System.Drawing.Size(94, 15);
            this.llbl_recuperarSenha.TabIndex = 5;
            this.llbl_recuperarSenha.TabStop = true;
            this.llbl_recuperarSenha.Text = "Recuperar senha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.llbl_recuperarSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.llbl_criarConta);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 144);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 243);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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