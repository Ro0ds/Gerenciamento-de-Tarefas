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
            panel1 = new Panel();
            txt_email = new TextBox();
            label5 = new Label();
            txt_senha = new TextBox();
            label3 = new Label();
            txt_dicaSenha = new TextBox();
            label4 = new Label();
            txt_nomeCompleto = new TextBox();
            label1 = new Label();
            txt_usuario = new TextBox();
            btn_enviarRecuperaSenha = new Button();
            label2 = new Label();
            lbl_title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_dicaSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_nomeCompleto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(btn_enviarRecuperaSenha);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(34, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 244);
            panel1.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.CharacterCasing = CharacterCasing.Lower;
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(185, 50);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "email@email.com";
            txt_email.Size = new Size(204, 29);
            txt_email.TabIndex = 2;
            txt_email.Tag = "camposObrigatorios";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 54);
            label5.Name = "label5";
            label5.Size = new Size(169, 23);
            label5.TabIndex = 11;
            label5.Text = "E-mail:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(185, 120);
            txt_senha.Name = "txt_senha";
            txt_senha.PlaceholderText = "Senha";
            txt_senha.Size = new Size(204, 29);
            txt_senha.TabIndex = 4;
            txt_senha.Tag = "camposObrigatorios";
            txt_senha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 124);
            label3.Name = "label3";
            label3.Size = new Size(169, 23);
            label3.TabIndex = 7;
            label3.Text = "Senha:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_dicaSenha
            // 
            txt_dicaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dicaSenha.Location = new Point(185, 156);
            txt_dicaSenha.Name = "txt_dicaSenha";
            txt_dicaSenha.PlaceholderText = "Dica para senha";
            txt_dicaSenha.Size = new Size(204, 29);
            txt_dicaSenha.TabIndex = 5;
            txt_dicaSenha.Tag = "camposObrigatorios";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 159);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 9;
            label4.Text = "Dica da senha:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_nomeCompleto
            // 
            txt_nomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeCompleto.Location = new Point(185, 15);
            txt_nomeCompleto.Name = "txt_nomeCompleto";
            txt_nomeCompleto.PlaceholderText = "Seu nome";
            txt_nomeCompleto.Size = new Size(204, 29);
            txt_nomeCompleto.TabIndex = 1;
            txt_nomeCompleto.Tag = "camposObrigatorios";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 1;
            label1.Text = "Nome Completo:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(185, 85);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Seu nome de usuário";
            txt_usuario.Size = new Size(204, 29);
            txt_usuario.TabIndex = 3;
            txt_usuario.Tag = "camposObrigatorios";
            // 
            // btn_enviarRecuperaSenha
            // 
            btn_enviarRecuperaSenha.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_enviarRecuperaSenha.Location = new Point(10, 191);
            btn_enviarRecuperaSenha.Name = "btn_enviarRecuperaSenha";
            btn_enviarRecuperaSenha.Size = new Size(379, 37);
            btn_enviarRecuperaSenha.TabIndex = 6;
            btn_enviarRecuperaSenha.Text = "Enviar";
            btn_enviarRecuperaSenha.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 88);
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
            ClientSize = new Size(466, 324);
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
        private TextBox txt_senha;
        private Label label3;
        private TextBox txt_dicaSenha;
        private Label label4;
        private TextBox txt_nomeCompleto;
        private Label label1;
        private TextBox txt_usuario;
        private Button btn_enviarRecuperaSenha;
        private Label label2;
        private Label lbl_title;
    }
}