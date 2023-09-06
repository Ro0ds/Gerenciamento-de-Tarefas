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
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdicionarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelSecundario = new System.Windows.Forms.Panel();
            this.menuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.tarefasToolStripMenuItem,
            this.bancoDeDadosToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(1080, 24);
            this.menuSuperior.TabIndex = 0;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdicionarUsuario,
            this.editarToolStripMenuItem1,
            this.excluirToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // menuAdicionarUsuario
            // 
            this.menuAdicionarUsuario.Name = "menuAdicionarUsuario";
            this.menuAdicionarUsuario.Size = new System.Drawing.Size(125, 22);
            this.menuAdicionarUsuario.Text = "Adicionar";
            this.menuAdicionarUsuario.Click += new System.EventHandler(this.menuAdicionarUsuario_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // tarefasToolStripMenuItem
            // 
            this.tarefasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.excluirToolStripMenuItem1,
            this.excluirToolStripMenuItem2});
            this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tarefasToolStripMenuItem.Text = "Tarefas";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.excluirToolStripMenuItem1.Text = "Editar";
            // 
            // excluirToolStripMenuItem2
            // 
            this.excluirToolStripMenuItem2.Name = "excluirToolStripMenuItem2";
            this.excluirToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.excluirToolStripMenuItem2.Text = "Excluir";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // painelSecundario
            // 
            this.painelSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelSecundario.Location = new System.Drawing.Point(0, 24);
            this.painelSecundario.Name = "painelSecundario";
            this.painelSecundario.Size = new System.Drawing.Size(1080, 696);
            this.painelSecundario.TabIndex = 1;
            // 
            // PainelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.painelSecundario);
            this.Controls.Add(this.menuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuSuperior;
            this.Name = "PainelAdministrador";
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuSuperior;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem menuAdicionarUsuario;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem1;
        private Panel painelSecundario;
        private ToolStripMenuItem excluirToolStripMenuItem2;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem configurarToolStripMenuItem;
    }
}