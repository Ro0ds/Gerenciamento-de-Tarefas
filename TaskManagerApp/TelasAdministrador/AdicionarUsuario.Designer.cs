namespace TaskManagerApp.TelasAdministrador
{
    partial class AdicionarUsuario
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
            btn_adicionar = new Button();
            label1 = new Label();
            txt_nomeCompleto = new TextBox();
            txt_nomeUsuario = new TextBox();
            label2 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_senha = new TextBox();
            label4 = new Label();
            txt_dicaSenha = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cb_grupoPermissao = new ComboBox();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_adicionar.Location = new Point(84, 455);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(744, 44);
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 111);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 1;
            label1.Text = "Nome Completo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nomeCompleto
            // 
            txt_nomeCompleto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeCompleto.Location = new Point(84, 155);
            txt_nomeCompleto.Name = "txt_nomeCompleto";
            txt_nomeCompleto.PlaceholderText = "digite o nome completo";
            txt_nomeCompleto.Size = new Size(355, 32);
            txt_nomeCompleto.TabIndex = 2;
            // 
            // txt_nomeUsuario
            // 
            txt_nomeUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeUsuario.Location = new Point(473, 155);
            txt_nomeUsuario.Name = "txt_nomeUsuario";
            txt_nomeUsuario.PlaceholderText = "digite um nome de usuário";
            txt_nomeUsuario.Size = new Size(355, 32);
            txt_nomeUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(473, 111);
            label2.Name = "label2";
            label2.Size = new Size(197, 41);
            label2.TabIndex = 3;
            label2.Text = "Nome de Usuário";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(84, 266);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "digite um e-mail válido";
            txt_email.Size = new Size(355, 32);
            txt_email.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 222);
            label3.Name = "label3";
            label3.Size = new Size(197, 41);
            label3.TabIndex = 5;
            label3.Text = "E-mail";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(473, 266);
            txt_senha.Name = "txt_senha";
            txt_senha.PlaceholderText = "escolha uma senha segura";
            txt_senha.Size = new Size(355, 32);
            txt_senha.TabIndex = 8;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(473, 222);
            label4.Name = "label4";
            label4.Size = new Size(197, 41);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_dicaSenha
            // 
            txt_dicaSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dicaSenha.Location = new Point(84, 383);
            txt_dicaSenha.Name = "txt_dicaSenha";
            txt_dicaSenha.PlaceholderText = "dica para o usuário conseguir logar";
            txt_dicaSenha.Size = new Size(355, 32);
            txt_dicaSenha.TabIndex = 10;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(84, 339);
            label5.Name = "label5";
            label5.Size = new Size(197, 41);
            label5.TabIndex = 9;
            label5.Text = "Dica de Senha";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(473, 348);
            label6.Name = "label6";
            label6.Size = new Size(197, 41);
            label6.TabIndex = 11;
            label6.Text = "Grupo Permissão";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb_grupoPermissao
            // 
            cb_grupoPermissao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_grupoPermissao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_grupoPermissao.FormattingEnabled = true;
            cb_grupoPermissao.Items.AddRange(new object[] { "USUARIO", "ADMINISTRADOR" });
            cb_grupoPermissao.Location = new Point(473, 392);
            cb_grupoPermissao.Name = "cb_grupoPermissao";
            cb_grupoPermissao.Size = new Size(355, 23);
            cb_grupoPermissao.TabIndex = 12;
            // 
            // AdicionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 613);
            Controls.Add(cb_grupoPermissao);
            Controls.Add(label6);
            Controls.Add(txt_dicaSenha);
            Controls.Add(label5);
            Controls.Add(txt_senha);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(txt_nomeUsuario);
            Controls.Add(label2);
            Controls.Add(txt_nomeCompleto);
            Controls.Add(label1);
            Controls.Add(btn_adicionar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdicionarUsuario";
            Text = "AdicionarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private Label label1;
        private TextBox txt_nomeCompleto;
        private TextBox txt_nomeUsuario;
        private Label label2;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_senha;
        private Label label4;
        private TextBox txt_dicaSenha;
        private Label label5;
        private Label label6;
        private ComboBox cb_grupoPermissao;
    }
}