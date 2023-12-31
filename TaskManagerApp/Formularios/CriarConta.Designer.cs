﻿namespace TaskManagerApp.Formularios
{
    partial class CriarConta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dicaSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(466, 44);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "TaskManagerApp - ";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_dicaSenha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nomeCompleto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(34, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 244);
            this.panel1.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(185, 50);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderText = "email@email.com";
            this.txt_email.Size = new System.Drawing.Size(204, 29);
            this.txt_email.TabIndex = 2;
            this.txt_email.Tag = "camposObrigatorios";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-mail:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.Location = new System.Drawing.Point(185, 120);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PlaceholderText = "Senha";
            this.txt_senha.Size = new System.Drawing.Size(204, 29);
            this.txt_senha.TabIndex = 4;
            this.txt_senha.Tag = "camposObrigatorios";
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dicaSenha
            // 
            this.txt_dicaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dicaSenha.Location = new System.Drawing.Point(185, 156);
            this.txt_dicaSenha.Name = "txt_dicaSenha";
            this.txt_dicaSenha.PlaceholderText = "Dica para senha";
            this.txt_dicaSenha.Size = new System.Drawing.Size(204, 29);
            this.txt_dicaSenha.TabIndex = 5;
            this.txt_dicaSenha.Tag = "camposObrigatorios";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dica da senha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nomeCompleto
            // 
            this.txt_nomeCompleto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nomeCompleto.Location = new System.Drawing.Point(185, 15);
            this.txt_nomeCompleto.Name = "txt_nomeCompleto";
            this.txt_nomeCompleto.PlaceholderText = "Seu nome";
            this.txt_nomeCompleto.Size = new System.Drawing.Size(204, 29);
            this.txt_nomeCompleto.TabIndex = 1;
            this.txt_nomeCompleto.Tag = "camposObrigatorios";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(185, 85);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Seu nome de usuário";
            this.txt_usuario.Size = new System.Drawing.Size(204, 29);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.Tag = "camposObrigatorios";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_entrar.Location = new System.Drawing.Point(10, 191);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(379, 37);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "Cadastrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CriarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_title;
        private Panel panel1;
        private TextBox txt_senha;
        private Label label3;
        private TextBox txt_dicaSenha;
        private Label label4;
        private TextBox txt_nomeCompleto;
        private Label label1;
        private TextBox txt_usuario;
        private Button btn_entrar;
        private Label label2;
        private TextBox txt_email;
        private Label label5;
    }
}