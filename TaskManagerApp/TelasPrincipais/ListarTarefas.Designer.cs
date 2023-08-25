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
            this.gridListarTarefas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridListarTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListarTarefas
            // 
            this.gridListarTarefas.AllowUserToAddRows = false;
            this.gridListarTarefas.AllowUserToDeleteRows = false;
            this.gridListarTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListarTarefas.Location = new System.Drawing.Point(12, 12);
            this.gridListarTarefas.Name = "gridListarTarefas";
            this.gridListarTarefas.ReadOnly = true;
            this.gridListarTarefas.RowTemplate.Height = 25;
            this.gridListarTarefas.Size = new System.Drawing.Size(528, 299);
            this.gridListarTarefas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(319, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 100);
            this.panel2.TabIndex = 3;
            // 
            // ListarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridListarTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarTarefas";
            this.Text = "ListarTarefas";
            ((System.ComponentModel.ISupportInitialize)(this.gridListarTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridListarTarefas;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}