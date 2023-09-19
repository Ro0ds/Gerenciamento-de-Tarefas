namespace TaskManagerApp.TelasPrincipais
{
    partial class EditarTarefas
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
            gridTarefas = new DataGridView();
            label1 = new Label();
            txt_codTarefa = new TextBox();
            rctxt_descricao = new RichTextBox();
            dt_termina = new DateTimePicker();
            txt_nomeTarefa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_prioridade = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dt_criada = new DateTimePicker();
            btn_editar = new Button();
            btn_buscar = new Button();
            cb_status = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridTarefas).BeginInit();
            SuspendLayout();
            // 
            // gridTarefas
            // 
            gridTarefas.AllowUserToAddRows = false;
            gridTarefas.AllowUserToDeleteRows = false;
            gridTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTarefas.Dock = DockStyle.Left;
            gridTarefas.Location = new Point(0, 0);
            gridTarefas.Name = "gridTarefas";
            gridTarefas.ReadOnly = true;
            gridTarefas.RowTemplate.Height = 25;
            gridTarefas.Size = new Size(377, 434);
            gridTarefas.TabIndex = 10000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 10001;
            label1.Text = "Código da Tarefa";
            // 
            // txt_codTarefa
            // 
            txt_codTarefa.Location = new Point(451, 39);
            txt_codTarefa.Name = "txt_codTarefa";
            txt_codTarefa.Size = new Size(96, 23);
            txt_codTarefa.TabIndex = 1;
            // 
            // rctxt_descricao
            // 
            rctxt_descricao.Enabled = false;
            rctxt_descricao.Location = new Point(403, 142);
            rctxt_descricao.Name = "rctxt_descricao";
            rctxt_descricao.Size = new Size(248, 53);
            rctxt_descricao.TabIndex = 10003;
            rctxt_descricao.Tag = "camposEdicao";
            rctxt_descricao.Text = "";
            // 
            // dt_termina
            // 
            dt_termina.Enabled = false;
            dt_termina.Format = DateTimePickerFormat.Short;
            dt_termina.Location = new Point(403, 216);
            dt_termina.Name = "dt_termina";
            dt_termina.Size = new Size(248, 23);
            dt_termina.TabIndex = 5;
            dt_termina.Tag = "camposEdicao";
            // 
            // txt_nomeTarefa
            // 
            txt_nomeTarefa.Enabled = false;
            txt_nomeTarefa.Location = new Point(403, 98);
            txt_nomeTarefa.Name = "txt_nomeTarefa";
            txt_nomeTarefa.Size = new Size(248, 23);
            txt_nomeTarefa.TabIndex = 3;
            txt_nomeTarefa.Tag = "camposEdicao";
            // 
            // label2
            // 
            label2.Location = new Point(403, 80);
            label2.Name = "label2";
            label2.Size = new Size(248, 15);
            label2.TabIndex = 10005;
            label2.Text = "Nome da Tarefa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(403, 124);
            label3.Name = "label3";
            label3.Size = new Size(248, 15);
            label3.TabIndex = 10007;
            label3.Text = "Descrição da Tarefa";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(403, 198);
            label4.Name = "label4";
            label4.Size = new Size(248, 15);
            label4.TabIndex = 10008;
            label4.Text = "Termina em";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_prioridade
            // 
            cb_prioridade.AutoCompleteMode = AutoCompleteMode.Append;
            cb_prioridade.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_prioridade.Enabled = false;
            cb_prioridade.FormattingEnabled = true;
            cb_prioridade.Items.AddRange(new object[] { "BaixaPrioridade", "MediaPrioridade", "AltaPrioridade" });
            cb_prioridade.Location = new Point(403, 260);
            cb_prioridade.Name = "cb_prioridade";
            cb_prioridade.Size = new Size(248, 23);
            cb_prioridade.TabIndex = 6;
            cb_prioridade.Tag = "camposEdicao";
            // 
            // label5
            // 
            label5.Location = new Point(403, 242);
            label5.Name = "label5";
            label5.Size = new Size(248, 15);
            label5.TabIndex = 10010;
            label5.Text = "Prioridade";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(403, 286);
            label6.Name = "label6";
            label6.Size = new Size(248, 15);
            label6.TabIndex = 10011;
            label6.Text = "Status da Tarefa";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new Point(403, 330);
            label7.Name = "label7";
            label7.Size = new Size(248, 15);
            label7.TabIndex = 10014;
            label7.Text = "Criada em";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dt_criada
            // 
            dt_criada.Enabled = false;
            dt_criada.Format = DateTimePickerFormat.Short;
            dt_criada.Location = new Point(403, 348);
            dt_criada.Name = "dt_criada";
            dt_criada.Size = new Size(248, 23);
            dt_criada.TabIndex = 8;
            dt_criada.Tag = "";
            // 
            // btn_editar
            // 
            btn_editar.Enabled = false;
            btn_editar.Location = new Point(403, 381);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(248, 35);
            btn_editar.TabIndex = 9;
            btn_editar.Tag = "camposEdicao";
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(553, 39);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // cb_status
            // 
            cb_status.AutoCompleteMode = AutoCompleteMode.Append;
            cb_status.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_status.Enabled = false;
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Criada", "EmAndamento", "Finalizada" });
            cb_status.Location = new Point(403, 304);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(248, 23);
            cb_status.TabIndex = 10015;
            cb_status.Tag = "camposEdicao";
            // 
            // EditarTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 434);
            Controls.Add(cb_status);
            Controls.Add(btn_buscar);
            Controls.Add(btn_editar);
            Controls.Add(label7);
            Controls.Add(dt_criada);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cb_prioridade);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_nomeTarefa);
            Controls.Add(label2);
            Controls.Add(dt_termina);
            Controls.Add(rctxt_descricao);
            Controls.Add(txt_codTarefa);
            Controls.Add(label1);
            Controls.Add(gridTarefas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarTarefas";
            Text = "EditarTarefas";
            ((System.ComponentModel.ISupportInitialize)gridTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTarefas;
        private Label label1;
        private TextBox txt_codTarefa;
        private RichTextBox rctxt_descricao;
        private DateTimePicker dt_termina;
        private TextBox txt_nomeTarefa;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_prioridade;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dt_criada;
        private Button btn_editar;
        private Button btn_buscar;
        private ComboBox cb_status;
    }
}