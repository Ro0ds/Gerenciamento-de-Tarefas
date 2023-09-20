namespace TaskManagerApp.TelasPrincipais
{
    partial class ListarTarefas
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
            gridListarTarefas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridListarTarefas).BeginInit();
            SuspendLayout();
            // 
            // gridListarTarefas
            // 
            gridListarTarefas.AllowUserToAddRows = false;
            gridListarTarefas.AllowUserToDeleteRows = false;
            gridListarTarefas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridListarTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridListarTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListarTarefas.Location = new Point(12, 12);
            gridListarTarefas.Name = "gridListarTarefas";
            gridListarTarefas.ReadOnly = true;
            gridListarTarefas.RowTemplate.Height = 25;
            gridListarTarefas.Size = new Size(528, 410);
            gridListarTarefas.TabIndex = 0;
            // 
            // ListarTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 434);
            Controls.Add(gridListarTarefas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarTarefas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarTarefas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridListarTarefas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridListarTarefas;
    }
}