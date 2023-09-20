namespace TaskManagerApp.TelasPrincipais
{
    partial class StatusTarefas
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
            gridStatusTarefas = new DataGridView();
            rd_baixaP = new RadioButton();
            rd_mediaP = new RadioButton();
            rd_altaP = new RadioButton();
            grupoPrioridade = new GroupBox();
            grupoStatus = new GroupBox();
            rd_criadoS = new RadioButton();
            rd_finalizadoS = new RadioButton();
            rd_andamentoS = new RadioButton();
            btn_filtro = new Button();
            ((System.ComponentModel.ISupportInitialize)gridStatusTarefas).BeginInit();
            grupoPrioridade.SuspendLayout();
            grupoStatus.SuspendLayout();
            SuspendLayout();
            // 
            // gridStatusTarefas
            // 
            gridStatusTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridStatusTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStatusTarefas.Dock = DockStyle.Top;
            gridStatusTarefas.Location = new Point(0, 0);
            gridStatusTarefas.Name = "gridStatusTarefas";
            gridStatusTarefas.ReadOnly = true;
            gridStatusTarefas.RowTemplate.Height = 25;
            gridStatusTarefas.Size = new Size(552, 314);
            gridStatusTarefas.TabIndex = 0;
            // 
            // rd_baixaP
            // 
            rd_baixaP.AutoSize = true;
            rd_baixaP.Location = new Point(25, 22);
            rd_baixaP.Name = "rd_baixaP";
            rd_baixaP.Size = new Size(110, 19);
            rd_baixaP.TabIndex = 1;
            rd_baixaP.TabStop = true;
            rd_baixaP.Tag = "BaixaPrioridade";
            rd_baixaP.Text = "Baixa Prioridade";
            rd_baixaP.UseVisualStyleBackColor = true;
            // 
            // rd_mediaP
            // 
            rd_mediaP.AutoSize = true;
            rd_mediaP.Location = new Point(25, 47);
            rd_mediaP.Name = "rd_mediaP";
            rd_mediaP.Size = new Size(115, 19);
            rd_mediaP.TabIndex = 2;
            rd_mediaP.TabStop = true;
            rd_mediaP.Tag = "MediaPrioridade";
            rd_mediaP.Text = "Média Prioridade";
            rd_mediaP.UseVisualStyleBackColor = true;
            // 
            // rd_altaP
            // 
            rd_altaP.AutoSize = true;
            rd_altaP.Location = new Point(25, 72);
            rd_altaP.Name = "rd_altaP";
            rd_altaP.Size = new Size(103, 19);
            rd_altaP.TabIndex = 3;
            rd_altaP.TabStop = true;
            rd_altaP.Tag = "AltaPrioridade";
            rd_altaP.Text = "Alta Prioridade";
            rd_altaP.UseVisualStyleBackColor = true;
            // 
            // grupoPrioridade
            // 
            grupoPrioridade.Controls.Add(rd_baixaP);
            grupoPrioridade.Controls.Add(rd_altaP);
            grupoPrioridade.Controls.Add(rd_mediaP);
            grupoPrioridade.Location = new Point(12, 322);
            grupoPrioridade.Name = "grupoPrioridade";
            grupoPrioridade.Size = new Size(162, 102);
            grupoPrioridade.TabIndex = 4;
            grupoPrioridade.TabStop = false;
            grupoPrioridade.Text = "Prioridade";
            // 
            // grupoStatus
            // 
            grupoStatus.Controls.Add(rd_criadoS);
            grupoStatus.Controls.Add(rd_finalizadoS);
            grupoStatus.Controls.Add(rd_andamentoS);
            grupoStatus.Location = new Point(212, 322);
            grupoStatus.Name = "grupoStatus";
            grupoStatus.Size = new Size(162, 102);
            grupoStatus.TabIndex = 5;
            grupoStatus.TabStop = false;
            grupoStatus.Text = "Status";
            // 
            // rd_criadoS
            // 
            rd_criadoS.AutoSize = true;
            rd_criadoS.Location = new Point(25, 22);
            rd_criadoS.Name = "rd_criadoS";
            rd_criadoS.Size = new Size(60, 19);
            rd_criadoS.TabIndex = 1;
            rd_criadoS.TabStop = true;
            rd_criadoS.Tag = "Criado";
            rd_criadoS.Text = "Criado";
            rd_criadoS.UseVisualStyleBackColor = true;
            // 
            // rd_finalizadoS
            // 
            rd_finalizadoS.AutoSize = true;
            rd_finalizadoS.Location = new Point(25, 72);
            rd_finalizadoS.Name = "rd_finalizadoS";
            rd_finalizadoS.Size = new Size(78, 19);
            rd_finalizadoS.TabIndex = 3;
            rd_finalizadoS.TabStop = true;
            rd_finalizadoS.Tag = "Finalizado";
            rd_finalizadoS.Text = "Finalizado";
            rd_finalizadoS.UseVisualStyleBackColor = true;
            // 
            // rd_andamentoS
            // 
            rd_andamentoS.AutoSize = true;
            rd_andamentoS.Location = new Point(25, 47);
            rd_andamentoS.Name = "rd_andamentoS";
            rd_andamentoS.Size = new Size(106, 19);
            rd_andamentoS.TabIndex = 2;
            rd_andamentoS.TabStop = true;
            rd_andamentoS.Tag = "EmAndamento";
            rd_andamentoS.Text = "Em andamento";
            rd_andamentoS.UseVisualStyleBackColor = true;
            // 
            // btn_filtro
            // 
            btn_filtro.Location = new Point(407, 326);
            btn_filtro.Name = "btn_filtro";
            btn_filtro.Size = new Size(133, 102);
            btn_filtro.TabIndex = 6;
            btn_filtro.Text = "Filtrar";
            btn_filtro.UseVisualStyleBackColor = true;
            btn_filtro.Click += btn_filtro_Click;
            // 
            // StatusTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 434);
            Controls.Add(btn_filtro);
            Controls.Add(grupoStatus);
            Controls.Add(grupoPrioridade);
            Controls.Add(gridStatusTarefas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatusTarefas";
            Text = "StatusTarefas";
            ((System.ComponentModel.ISupportInitialize)gridStatusTarefas).EndInit();
            grupoPrioridade.ResumeLayout(false);
            grupoPrioridade.PerformLayout();
            grupoStatus.ResumeLayout(false);
            grupoStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridStatusTarefas;
        private RadioButton rd_baixaP;
        private RadioButton rd_mediaP;
        private RadioButton rd_altaP;
        private GroupBox grupoPrioridade;
        private GroupBox grupoStatus;
        private RadioButton rd_criadoS;
        private RadioButton rd_finalizadoS;
        private RadioButton rd_andamentoS;
        private Button btn_filtro;
    }
}