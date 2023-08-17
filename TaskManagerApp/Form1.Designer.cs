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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_perfilUsuario = new System.Windows.Forms.Label();
            this.lbl_configuracoes = new System.Windows.Forms.Label();
            this.lbl_statusTarefa = new System.Windows.Forms.Label();
            this.lbl_editarTarefa = new System.Windows.Forms.Label();
            this.lbl_detalharTarefa = new System.Windows.Forms.Label();
            this.lbl_listarTarefa = new System.Windows.Forms.Label();
            this.lbl_criarTarefa = new System.Windows.Forms.Label();
            this.lbl_menuPrincipal = new System.Windows.Forms.Label();
            this.painel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(708, 44);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_perfilUsuario);
            this.panel1.Controls.Add(this.lbl_configuracoes);
            this.panel1.Controls.Add(this.lbl_statusTarefa);
            this.panel1.Controls.Add(this.lbl_editarTarefa);
            this.panel1.Controls.Add(this.lbl_detalharTarefa);
            this.panel1.Controls.Add(this.lbl_listarTarefa);
            this.panel1.Controls.Add(this.lbl_criarTarefa);
            this.panel1.Controls.Add(this.lbl_menuPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 434);
            this.panel1.TabIndex = 3;
            // 
            // lbl_perfilUsuario
            // 
            this.lbl_perfilUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_perfilUsuario.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfilUsuario.Location = new System.Drawing.Point(0, 260);
            this.lbl_perfilUsuario.Name = "lbl_perfilUsuario";
            this.lbl_perfilUsuario.Size = new System.Drawing.Size(153, 32);
            this.lbl_perfilUsuario.TabIndex = 11;
            this.lbl_perfilUsuario.Tag = "menu";
            this.lbl_perfilUsuario.Text = "Perfil de Usuário";
            this.lbl_perfilUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_perfilUsuario.Click += new System.EventHandler(this.lbl_perfilUsuario_Click);
            //this.lbl_perfilUsuario.MouseLeave += new System.EventHandler(this.lbl_perfilUsuario_MouseLeave);
            this.lbl_perfilUsuario.MouseHover += new System.EventHandler(this.lbl_perfilUsuario_MouseHover);
            // 
            // lbl_configuracoes
            // 
            this.lbl_configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_configuracoes.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_configuracoes.Location = new System.Drawing.Point(0, 228);
            this.lbl_configuracoes.Name = "lbl_configuracoes";
            this.lbl_configuracoes.Size = new System.Drawing.Size(153, 32);
            this.lbl_configuracoes.TabIndex = 10;
            this.lbl_configuracoes.Tag = "menu";
            this.lbl_configuracoes.Text = "Configurações";
            this.lbl_configuracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_configuracoes.Click += new System.EventHandler(this.lbl_configuracoes_Click);
            //this.lbl_configuracoes.MouseLeave += new System.EventHandler(this.lbl_configuracoes_MouseLeave);
            this.lbl_configuracoes.MouseHover += new System.EventHandler(this.lbl_configuracoes_MouseHover);
            // 
            // lbl_statusTarefa
            // 
            this.lbl_statusTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_statusTarefa.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_statusTarefa.Location = new System.Drawing.Point(0, 196);
            this.lbl_statusTarefa.Name = "lbl_statusTarefa";
            this.lbl_statusTarefa.Size = new System.Drawing.Size(153, 32);
            this.lbl_statusTarefa.TabIndex = 9;
            this.lbl_statusTarefa.Tag = "menu";
            this.lbl_statusTarefa.Text = "Status das Tarefas";
            this.lbl_statusTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_statusTarefa.Click += new System.EventHandler(this.lbl_statusTarefa_Click);
            this.lbl_statusTarefa.MouseLeave += new System.EventHandler(this.lbl_statusTarefa_MouseLeave);
            this.lbl_statusTarefa.MouseHover += new System.EventHandler(this.lbl_statusTarefa_MouseHover);
            // 
            // lbl_editarTarefa
            // 
            this.lbl_editarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_editarTarefa.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_editarTarefa.Location = new System.Drawing.Point(0, 164);
            this.lbl_editarTarefa.Name = "lbl_editarTarefa";
            this.lbl_editarTarefa.Size = new System.Drawing.Size(153, 32);
            this.lbl_editarTarefa.TabIndex = 8;
            this.lbl_editarTarefa.Tag = "menu";
            this.lbl_editarTarefa.Text = "Editar Tarefas";
            this.lbl_editarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_editarTarefa.Click += new System.EventHandler(this.lbl_editarTarefa_Click);
            this.lbl_editarTarefa.MouseLeave += new System.EventHandler(this.lbl_editarTarefa_MouseLeave);
            this.lbl_editarTarefa.MouseHover += new System.EventHandler(this.lbl_editarTarefa_MouseHover);
            // 
            // lbl_detalharTarefa
            // 
            this.lbl_detalharTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_detalharTarefa.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_detalharTarefa.Location = new System.Drawing.Point(0, 132);
            this.lbl_detalharTarefa.Name = "lbl_detalharTarefa";
            this.lbl_detalharTarefa.Size = new System.Drawing.Size(153, 32);
            this.lbl_detalharTarefa.TabIndex = 7;
            this.lbl_detalharTarefa.Tag = "menu";
            this.lbl_detalharTarefa.Text = "Detalhar Tarefas";
            this.lbl_detalharTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_detalharTarefa.Click += new System.EventHandler(this.lbl_detalharTarefa_Click);
            this.lbl_detalharTarefa.MouseLeave += new System.EventHandler(this.lbl_detalharTarefa_MouseLeave);
            this.lbl_detalharTarefa.MouseHover += new System.EventHandler(this.lbl_detalharTarefa_MouseHover);
            // 
            // lbl_listarTarefa
            // 
            this.lbl_listarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_listarTarefa.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_listarTarefa.Location = new System.Drawing.Point(0, 100);
            this.lbl_listarTarefa.Name = "lbl_listarTarefa";
            this.lbl_listarTarefa.Size = new System.Drawing.Size(153, 32);
            this.lbl_listarTarefa.TabIndex = 6;
            this.lbl_listarTarefa.Tag = "menu";
            this.lbl_listarTarefa.Text = "Listar Tarefas";
            this.lbl_listarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_listarTarefa.Click += new System.EventHandler(this.lbl_listarTarefa_Click);
            this.lbl_listarTarefa.MouseLeave += new System.EventHandler(this.lbl_listarTarefa_MouseLeave);
            this.lbl_listarTarefa.MouseHover += new System.EventHandler(this.lbl_listarTarefa_MouseHover);
            // 
            // lbl_criarTarefa
            // 
            this.lbl_criarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_criarTarefa.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_criarTarefa.Location = new System.Drawing.Point(0, 68);
            this.lbl_criarTarefa.Name = "lbl_criarTarefa";
            this.lbl_criarTarefa.Size = new System.Drawing.Size(153, 32);
            this.lbl_criarTarefa.TabIndex = 5;
            this.lbl_criarTarefa.Tag = "menu";
            this.lbl_criarTarefa.Text = "Criar Tarefas";
            this.lbl_criarTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_criarTarefa.Click += new System.EventHandler(this.lbl_criarTarefa_Click);
            this.lbl_criarTarefa.MouseLeave += new System.EventHandler(this.lbl_criarTarefa_MouseLeave);
            this.lbl_criarTarefa.MouseHover += new System.EventHandler(this.lbl_criarTarefa_MouseHover);
            // 
            // lbl_menuPrincipal
            // 
            this.lbl_menuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_menuPrincipal.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_menuPrincipal.Location = new System.Drawing.Point(0, 36);
            this.lbl_menuPrincipal.Name = "lbl_menuPrincipal";
            this.lbl_menuPrincipal.Size = new System.Drawing.Size(153, 32);
            this.lbl_menuPrincipal.TabIndex = 4;
            this.lbl_menuPrincipal.Tag = "menu";
            this.lbl_menuPrincipal.Text = "Menu Principal";
            this.lbl_menuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_menuPrincipal.Click += new System.EventHandler(this.lbl_menuPrincipal_Click);
            this.lbl_menuPrincipal.MouseLeave += new System.EventHandler(this.lbl_menuPrincipal_MouseLeave);
            this.lbl_menuPrincipal.MouseHover += new System.EventHandler(this.lbl_menuPrincipal_MouseHover);
            // 
            // painel
            // 
            this.painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel.Location = new System.Drawing.Point(156, 44);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(552, 434);
            this.painel.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 478);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager App";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_title;
        private Panel panel1;
        private Label lbl_menuPrincipal;
        private Label lbl_perfilUsuario;
        private Label lbl_configuracoes;
        private Label lbl_statusTarefa;
        private Label lbl_editarTarefa;
        private Label lbl_detalharTarefa;
        private Label lbl_listarTarefa;
        private Label lbl_criarTarefa;
        private Panel painel;
        public System.Windows.Forms.Timer timer;
    }
}