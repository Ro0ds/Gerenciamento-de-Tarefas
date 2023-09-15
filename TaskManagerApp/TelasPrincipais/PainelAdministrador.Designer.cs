namespace TaskManagerApp.TelasPrincipais
{
    partial class PainelAdministrador
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
            menuSuperior = new MenuStrip();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            menuAdicionarUsuario = new ToolStripMenuItem();
            menuEditarUsuario = new ToolStripMenuItem();
            menuExcluirUsuario = new ToolStripMenuItem();
            tarefasToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem1 = new ToolStripMenuItem();
            excluirToolStripMenuItem2 = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            configurarToolStripMenuItem = new ToolStripMenuItem();
            painelSecundario = new Panel();
            menuSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // menuSuperior
            // 
            menuSuperior.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, tarefasToolStripMenuItem, bancoDeDadosToolStripMenuItem });
            menuSuperior.Location = new Point(0, 0);
            menuSuperior.Name = "menuSuperior";
            menuSuperior.Size = new Size(1080, 24);
            menuSuperior.TabIndex = 0;
            menuSuperior.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuAdicionarUsuario, menuEditarUsuario, menuExcluirUsuario });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // menuAdicionarUsuario
            // 
            menuAdicionarUsuario.Name = "menuAdicionarUsuario";
            menuAdicionarUsuario.Size = new Size(180, 22);
            menuAdicionarUsuario.Text = "Adicionar";
            menuAdicionarUsuario.Click += menuAdicionarUsuario_Click;
            // 
            // menuEditarUsuario
            // 
            menuEditarUsuario.Name = "menuEditarUsuario";
            menuEditarUsuario.Size = new Size(180, 22);
            menuEditarUsuario.Text = "Editar";
            menuEditarUsuario.Click += menuEditarUsuario_Click;
            // 
            // menuExcluirUsuario
            // 
            menuExcluirUsuario.Name = "menuExcluirUsuario";
            menuExcluirUsuario.Size = new Size(180, 22);
            menuExcluirUsuario.Text = "Excluir";
            menuExcluirUsuario.Click += menuExcluirUsuario_Click;
            // 
            // tarefasToolStripMenuItem
            // 
            tarefasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarToolStripMenuItem, excluirToolStripMenuItem1, excluirToolStripMenuItem2 });
            tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            tarefasToolStripMenuItem.Size = new Size(55, 20);
            tarefasToolStripMenuItem.Text = "Tarefas";
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(123, 22);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // excluirToolStripMenuItem1
            // 
            excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            excluirToolStripMenuItem1.Size = new Size(123, 22);
            excluirToolStripMenuItem1.Text = "Editar";
            // 
            // excluirToolStripMenuItem2
            // 
            excluirToolStripMenuItem2.Name = "excluirToolStripMenuItem2";
            excluirToolStripMenuItem2.Size = new Size(123, 22);
            excluirToolStripMenuItem2.Text = "Excluir";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarToolStripMenuItem });
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(104, 20);
            bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            // 
            // configurarToolStripMenuItem
            // 
            configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            configurarToolStripMenuItem.Size = new Size(131, 22);
            configurarToolStripMenuItem.Text = "Configurar";
            // 
            // painelSecundario
            // 
            painelSecundario.Dock = DockStyle.Fill;
            painelSecundario.Location = new Point(0, 24);
            painelSecundario.Name = "painelSecundario";
            painelSecundario.Size = new Size(1080, 696);
            painelSecundario.TabIndex = 1;
            // 
            // PainelAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Controls.Add(painelSecundario);
            Controls.Add(menuSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuSuperior;
            Name = "PainelAdministrador";
            menuSuperior.ResumeLayout(false);
            menuSuperior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuSuperior;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem menuAdicionarUsuario;
        private ToolStripMenuItem menuEditarUsuario;
        private ToolStripMenuItem menuExcluirUsuario;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem1;
        private Panel painelSecundario;
        private ToolStripMenuItem excluirToolStripMenuItem2;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem;
    }
}