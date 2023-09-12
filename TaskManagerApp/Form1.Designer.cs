namespace TaskManagerApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_title = new Label();
            panel1 = new Panel();
            lbl_administrador = new Label();
            lbl_perfilUsuario = new Label();
            lbl_configuracoes = new Label();
            lbl_statusTarefa = new Label();
            lbl_editarTarefa = new Label();
            lbl_listarTarefa = new Label();
            lbl_criarTarefa = new Label();
            lbl_menuPrincipal = new Label();
            painel = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.BackColor = Color.WhiteSmoke;
            lbl_title.Dock = DockStyle.Top;
            lbl_title.FlatStyle = FlatStyle.Flat;
            lbl_title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.ForeColor = SystemColors.ActiveCaptionText;
            lbl_title.Location = new Point(0, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(708, 44);
            lbl_title.TabIndex = 2;
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            lbl_title.Click += lbl_title_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lbl_administrador);
            panel1.Controls.Add(lbl_perfilUsuario);
            panel1.Controls.Add(lbl_configuracoes);
            panel1.Controls.Add(lbl_statusTarefa);
            panel1.Controls.Add(lbl_editarTarefa);
            panel1.Controls.Add(lbl_listarTarefa);
            panel1.Controls.Add(lbl_criarTarefa);
            panel1.Controls.Add(lbl_menuPrincipal);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 434);
            panel1.TabIndex = 3;
            // 
            // lbl_administrador
            // 
            lbl_administrador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_administrador.Enabled = false;
            lbl_administrador.FlatStyle = FlatStyle.Flat;
            lbl_administrador.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_administrador.Location = new Point(2, 393);
            lbl_administrador.Name = "lbl_administrador";
            lbl_administrador.Size = new Size(153, 32);
            lbl_administrador.TabIndex = 12;
            lbl_administrador.Tag = "menu";
            lbl_administrador.Text = "Painel Administrativo";
            lbl_administrador.TextAlign = ContentAlignment.MiddleRight;
            lbl_administrador.Visible = false;
            lbl_administrador.Click += lbl_administrador_Click;
            lbl_administrador.MouseLeave += lbl_administrador_MouseLeave;
            lbl_administrador.MouseHover += lbl_administrador_MouseHover;
            // 
            // lbl_perfilUsuario
            // 
            lbl_perfilUsuario.FlatStyle = FlatStyle.Flat;
            lbl_perfilUsuario.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_perfilUsuario.Location = new Point(0, 228);
            lbl_perfilUsuario.Name = "lbl_perfilUsuario";
            lbl_perfilUsuario.Size = new Size(153, 32);
            lbl_perfilUsuario.TabIndex = 11;
            lbl_perfilUsuario.Tag = "menu";
            lbl_perfilUsuario.Text = "Perfil de Usuário";
            lbl_perfilUsuario.TextAlign = ContentAlignment.MiddleRight;
            lbl_perfilUsuario.Click += lbl_perfilUsuario_Click;
            lbl_perfilUsuario.MouseLeave += lbl_perfilUsuario_MouseLeave;
            lbl_perfilUsuario.MouseHover += lbl_perfilUsuario_MouseHover;
            // 
            // lbl_configuracoes
            // 
            lbl_configuracoes.FlatStyle = FlatStyle.Flat;
            lbl_configuracoes.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_configuracoes.Location = new Point(0, 196);
            lbl_configuracoes.Name = "lbl_configuracoes";
            lbl_configuracoes.Size = new Size(153, 32);
            lbl_configuracoes.TabIndex = 10;
            lbl_configuracoes.Tag = "menu";
            lbl_configuracoes.Text = "Configurações";
            lbl_configuracoes.TextAlign = ContentAlignment.MiddleRight;
            lbl_configuracoes.Click += lbl_configuracoes_Click;
            lbl_configuracoes.MouseLeave += lbl_configuracoes_MouseLeave;
            lbl_configuracoes.MouseHover += lbl_configuracoes_MouseHover;
            // 
            // lbl_statusTarefa
            // 
            lbl_statusTarefa.FlatStyle = FlatStyle.Flat;
            lbl_statusTarefa.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_statusTarefa.Location = new Point(0, 164);
            lbl_statusTarefa.Name = "lbl_statusTarefa";
            lbl_statusTarefa.Size = new Size(153, 32);
            lbl_statusTarefa.TabIndex = 9;
            lbl_statusTarefa.Tag = "menu";
            lbl_statusTarefa.Text = "Status das Tarefas";
            lbl_statusTarefa.TextAlign = ContentAlignment.MiddleRight;
            lbl_statusTarefa.Click += lbl_statusTarefa_Click;
            lbl_statusTarefa.MouseLeave += lbl_statusTarefa_MouseLeave;
            lbl_statusTarefa.MouseHover += lbl_statusTarefa_MouseHover;
            // 
            // lbl_editarTarefa
            // 
            lbl_editarTarefa.FlatStyle = FlatStyle.Flat;
            lbl_editarTarefa.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_editarTarefa.Location = new Point(0, 132);
            lbl_editarTarefa.Name = "lbl_editarTarefa";
            lbl_editarTarefa.Size = new Size(153, 32);
            lbl_editarTarefa.TabIndex = 8;
            lbl_editarTarefa.Tag = "menu";
            lbl_editarTarefa.Text = "Editar Tarefas";
            lbl_editarTarefa.TextAlign = ContentAlignment.MiddleRight;
            lbl_editarTarefa.Click += lbl_editarTarefa_Click;
            lbl_editarTarefa.MouseLeave += lbl_editarTarefa_MouseLeave;
            lbl_editarTarefa.MouseHover += lbl_editarTarefa_MouseHover;
            // 
            // lbl_listarTarefa
            // 
            lbl_listarTarefa.FlatStyle = FlatStyle.Flat;
            lbl_listarTarefa.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_listarTarefa.Location = new Point(0, 100);
            lbl_listarTarefa.Name = "lbl_listarTarefa";
            lbl_listarTarefa.Size = new Size(153, 32);
            lbl_listarTarefa.TabIndex = 6;
            lbl_listarTarefa.Tag = "menu";
            lbl_listarTarefa.Text = "Listar Tarefas";
            lbl_listarTarefa.TextAlign = ContentAlignment.MiddleRight;
            lbl_listarTarefa.Click += lbl_listarTarefa_Click;
            lbl_listarTarefa.MouseLeave += lbl_listarTarefa_MouseLeave;
            lbl_listarTarefa.MouseHover += lbl_listarTarefa_MouseHover;
            // 
            // lbl_criarTarefa
            // 
            lbl_criarTarefa.FlatStyle = FlatStyle.Flat;
            lbl_criarTarefa.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_criarTarefa.Location = new Point(0, 68);
            lbl_criarTarefa.Name = "lbl_criarTarefa";
            lbl_criarTarefa.Size = new Size(153, 32);
            lbl_criarTarefa.TabIndex = 5;
            lbl_criarTarefa.Tag = "menu";
            lbl_criarTarefa.Text = "Criar Tarefas";
            lbl_criarTarefa.TextAlign = ContentAlignment.MiddleRight;
            lbl_criarTarefa.Click += lbl_criarTarefa_Click;
            lbl_criarTarefa.MouseLeave += lbl_criarTarefa_MouseLeave;
            lbl_criarTarefa.MouseHover += lbl_criarTarefa_MouseHover;
            // 
            // lbl_menuPrincipal
            // 
            lbl_menuPrincipal.FlatStyle = FlatStyle.Flat;
            lbl_menuPrincipal.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_menuPrincipal.Location = new Point(0, 36);
            lbl_menuPrincipal.Name = "lbl_menuPrincipal";
            lbl_menuPrincipal.Size = new Size(153, 32);
            lbl_menuPrincipal.TabIndex = 4;
            lbl_menuPrincipal.Tag = "menu";
            lbl_menuPrincipal.Text = "Menu Principal";
            lbl_menuPrincipal.TextAlign = ContentAlignment.MiddleRight;
            lbl_menuPrincipal.Click += lbl_menuPrincipal_Click;
            lbl_menuPrincipal.MouseLeave += lbl_menuPrincipal_MouseLeave;
            lbl_menuPrincipal.MouseHover += lbl_menuPrincipal_MouseHover;
            // 
            // painel
            // 
            painel.Dock = DockStyle.Fill;
            painel.Location = new Point(156, 44);
            painel.Name = "painel";
            painel.Size = new Size(552, 434);
            painel.TabIndex = 4;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(708, 478);
            Controls.Add(painel);
            Controls.Add(panel1);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager App";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_title;
        private Panel panel1;
        private Label lbl_menuPrincipal;
        private Label lbl_perfilUsuario;
        private Label lbl_configuracoes;
        private Label lbl_statusTarefa;
        private Label lbl_editarTarefa;
        private Label lbl_listarTarefa;
        private Label lbl_criarTarefa;
        private Panel painel;
        public System.Windows.Forms.Timer timer;
        private Label lbl_administrador;
    }
}