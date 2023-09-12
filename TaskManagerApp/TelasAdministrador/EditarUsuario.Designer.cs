namespace TaskManagerApp.TelasAdministrador
{
    partial class EditarUsuario
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
            gridUsuarios = new DataGridView();
            cb_grupoPermissao = new ComboBox();
            label6 = new Label();
            txt_dicaSenha = new TextBox();
            label5 = new Label();
            txt_senha = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_nomeUsuario = new TextBox();
            label2 = new Label();
            txt_nomeCompleto = new TextBox();
            label1 = new Label();
            btn_modificar = new Button();
            txt_codUsuario = new TextBox();
            label7 = new Label();
            btn_mudar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Dock = DockStyle.Left;
            gridUsuarios.Location = new Point(0, 0);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(237, 574);
            gridUsuarios.TabIndex = 9999;
            // 
            // cb_grupoPermissao
            // 
            cb_grupoPermissao.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_grupoPermissao.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_grupoPermissao.Enabled = false;
            cb_grupoPermissao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_grupoPermissao.FormattingEnabled = true;
            cb_grupoPermissao.Items.AddRange(new object[] { "USUARIO", "ADMINISTRADOR" });
            cb_grupoPermissao.Location = new Point(588, 316);
            cb_grupoPermissao.Name = "cb_grupoPermissao";
            cb_grupoPermissao.Size = new Size(259, 28);
            cb_grupoPermissao.TabIndex = 7;
            cb_grupoPermissao.Tag = "usuario";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(588, 272);
            label6.Name = "label6";
            label6.Size = new Size(197, 41);
            label6.TabIndex = 24;
            label6.Text = "Grupo Permissão";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_dicaSenha
            // 
            txt_dicaSenha.Enabled = false;
            txt_dicaSenha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_dicaSenha.Location = new Point(315, 316);
            txt_dicaSenha.Name = "txt_dicaSenha";
            txt_dicaSenha.PlaceholderText = "dica para o usuário conseguir logar";
            txt_dicaSenha.Size = new Size(259, 26);
            txt_dicaSenha.TabIndex = 6;
            txt_dicaSenha.Tag = "usuario";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(315, 272);
            label5.Name = "label5";
            label5.Size = new Size(197, 41);
            label5.TabIndex = 22;
            label5.Text = "Dica de Senha";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_senha
            // 
            txt_senha.Enabled = false;
            txt_senha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.Location = new Point(588, 243);
            txt_senha.Name = "txt_senha";
            txt_senha.PlaceholderText = "escolha uma senha segura";
            txt_senha.Size = new Size(259, 26);
            txt_senha.TabIndex = 5;
            txt_senha.Tag = "usuario";
            txt_senha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(588, 199);
            label4.Name = "label4";
            label4.Size = new Size(197, 41);
            label4.TabIndex = 20;
            label4.Text = "Senha";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(315, 243);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "digite um e-mail válido";
            txt_email.Size = new Size(259, 26);
            txt_email.TabIndex = 4;
            txt_email.Tag = "usuario";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(315, 199);
            label3.Name = "label3";
            label3.Size = new Size(197, 41);
            label3.TabIndex = 18;
            label3.Text = "E-mail";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nomeUsuario
            // 
            txt_nomeUsuario.Enabled = false;
            txt_nomeUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeUsuario.Location = new Point(588, 158);
            txt_nomeUsuario.Name = "txt_nomeUsuario";
            txt_nomeUsuario.PlaceholderText = "digite um nome de usuário";
            txt_nomeUsuario.Size = new Size(259, 26);
            txt_nomeUsuario.TabIndex = 3;
            txt_nomeUsuario.Tag = "usuario";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(588, 114);
            label2.Name = "label2";
            label2.Size = new Size(197, 41);
            label2.TabIndex = 16;
            label2.Text = "Nome de Usuário";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_nomeCompleto
            // 
            txt_nomeCompleto.Enabled = false;
            txt_nomeCompleto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeCompleto.Location = new Point(315, 158);
            txt_nomeCompleto.Name = "txt_nomeCompleto";
            txt_nomeCompleto.PlaceholderText = "digite o nome completo";
            txt_nomeCompleto.Size = new Size(259, 26);
            txt_nomeCompleto.TabIndex = 2;
            txt_nomeCompleto.Tag = "usuario";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(315, 114);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 14;
            label1.Text = "Nome Completo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_modificar
            // 
            btn_modificar.Enabled = false;
            btn_modificar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificar.Location = new Point(315, 381);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(532, 36);
            btn_modificar.TabIndex = 8;
            btn_modificar.Tag = "usuario";
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // txt_codUsuario
            // 
            txt_codUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_codUsuario.Location = new Point(439, 64);
            txt_codUsuario.Name = "txt_codUsuario";
            txt_codUsuario.PlaceholderText = "digite o código do usuário";
            txt_codUsuario.Size = new Size(259, 26);
            txt_codUsuario.TabIndex = 1;
            txt_codUsuario.Tag = "codUsuario";
            txt_codUsuario.TextAlign = HorizontalAlignment.Center;
            txt_codUsuario.PreviewKeyDown += txt_codUsuario_PreviewKeyDown;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(439, 20);
            label7.Name = "label7";
            label7.Size = new Size(259, 41);
            label7.TabIndex = 26;
            label7.Text = "Código do Usuário";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_mudar
            // 
            btn_mudar.Location = new Point(704, 64);
            btn_mudar.Name = "btn_mudar";
            btn_mudar.Size = new Size(143, 26);
            btn_mudar.TabIndex = 10000;
            btn_mudar.Text = "Alterar";
            btn_mudar.UseVisualStyleBackColor = true;
            btn_mudar.Click += btn_mudar_Click;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 574);
            Controls.Add(btn_mudar);
            Controls.Add(txt_codUsuario);
            Controls.Add(label7);
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
            Controls.Add(btn_modificar);
            Controls.Add(gridUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarUsuario";
            Text = "EditarUsuario";
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridUsuarios;
        private ComboBox cb_grupoPermissao;
        private Label label6;
        private TextBox txt_dicaSenha;
        private Label label5;
        private TextBox txt_senha;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_nomeUsuario;
        private Label label2;
        private TextBox txt_nomeCompleto;
        private Label label1;
        private Button btn_modificar;
        private TextBox txt_codUsuario;
        private Label label7;
        private Button btn_mudar;
    }
}