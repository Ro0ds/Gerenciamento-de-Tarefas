namespace TaskManagerApp.Formularios
{
    partial class EsqueceuSenha
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
            if(disposing && (components != null))
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
            panel1 = new Panel();
            btn_resetaSenha = new Button();
            txt_senhaNovamente = new TextBox();
            lbl_novamente = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_novaSenha = new TextBox();
            lbl_senha = new Label();
            txt_usuario = new TextBox();
            btn_verificar = new Button();
            label2 = new Label();
            lbl_title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_resetaSenha);
            panel1.Controls.Add(txt_senhaNovamente);
            panel1.Controls.Add(lbl_novamente);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_novaSenha);
            panel1.Controls.Add(lbl_senha);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(btn_verificar);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(34, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 197);
            panel1.TabIndex = 2;
            // 
            // btn_resetaSenha
            // 
            btn_resetaSenha.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_resetaSenha.Location = new Point(206, 147);
            btn_resetaSenha.Name = "btn_resetaSenha";
            btn_resetaSenha.Size = new Size(183, 37);
            btn_resetaSenha.TabIndex = 14;
            btn_resetaSenha.Text = "Resetar Senha";
            btn_resetaSenha.UseVisualStyleBackColor = true;
            btn_resetaSenha.Click += btn_resetaSenha_Click;
            // 
            // txt_senhaNovamente
            // 
            txt_senhaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senhaNovamente.Location = new Point(185, 112);
            txt_senhaNovamente.Name = "txt_senhaNovamente";
            txt_senhaNovamente.PlaceholderText = "digite novamente a senha";
            txt_senhaNovamente.Size = new Size(204, 29);
            txt_senhaNovamente.TabIndex = 12;
            txt_senhaNovamente.Tag = "camposObrigatorios";
            txt_senhaNovamente.UseSystemPasswordChar = true;
            txt_senhaNovamente.Visible = false;
            // 
            // lbl_novamente
            // 
            lbl_novamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_novamente.Location = new Point(10, 115);
            lbl_novamente.Name = "lbl_novamente";
            lbl_novamente.Size = new Size(169, 21);
            lbl_novamente.TabIndex = 13;
            lbl_novamente.Text = "Digite novamente";
            lbl_novamente.TextAlign = ContentAlignment.MiddleCenter;
            lbl_novamente.Visible = false;
            // 
            // txt_email
            // 
            txt_email.CharacterCasing = CharacterCasing.Lower;
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(185, 7);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "email@email.com";
            txt_email.Size = new Size(204, 29);
            txt_email.TabIndex = 2;
            txt_email.Tag = "camposObrigatorios";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 11);
            label5.Name = "label5";
            label5.Size = new Size(169, 23);
            label5.TabIndex = 11;
            label5.Text = "E-mail:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_novaSenha
            // 
            txt_novaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_novaSenha.Location = new Point(185, 77);
            txt_novaSenha.Name = "txt_novaSenha";
            txt_novaSenha.PlaceholderText = "entre com a nova senha";
            txt_novaSenha.Size = new Size(204, 29);
            txt_novaSenha.TabIndex = 5;
            txt_novaSenha.Tag = "camposObrigatorios";
            txt_novaSenha.UseSystemPasswordChar = true;
            txt_novaSenha.Visible = false;
            // 
            // lbl_senha
            // 
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.Location = new Point(10, 80);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(169, 21);
            lbl_senha.TabIndex = 9;
            lbl_senha.Text = "Nova senha";
            lbl_senha.TextAlign = ContentAlignment.MiddleCenter;
            lbl_senha.Visible = false;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(185, 42);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Seu nome de usuário";
            txt_usuario.Size = new Size(204, 29);
            txt_usuario.TabIndex = 3;
            txt_usuario.Tag = "camposObrigatorios";
            // 
            // btn_verificar
            // 
            btn_verificar.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_verificar.Location = new Point(10, 147);
            btn_verificar.Name = "btn_verificar";
            btn_verificar.Size = new Size(183, 37);
            btn_verificar.TabIndex = 6;
            btn_verificar.Text = "Verificar";
            btn_verificar.UseVisualStyleBackColor = true;
            btn_verificar.Click += btn_verificar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 45);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 5;
            label2.Text = "Usuário:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            lbl_title.Dock = DockStyle.Top;
            lbl_title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(0, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(466, 44);
            lbl_title.TabIndex = 3;
            lbl_title.Text = "TaskManagerApp - ";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 281);
            Controls.Add(panel1);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EsqueceuSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperação de Senha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_novaSenha;
        private Label lbl_senha;
        private TextBox txt_usuario;
        private Button btn_verificar;
        private Label label2;
        private Label lbl_title;
        private TextBox txt_senhaNovamente;
        private Label lbl_novamente;
        private Button btn_resetaSenha;
    }
}