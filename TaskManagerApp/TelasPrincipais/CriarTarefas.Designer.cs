namespace TaskManagerApp.TelasPrincipais
{
    partial class CriarTarefas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_prioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rctxt_descricao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomeTarefa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_prioridade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp_dataVencimento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rctxt_descricao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nomeTarefa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 410);
            this.panel1.TabIndex = 9999;
            // 
            // txt_usuario
            // 
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new System.Drawing.Point(99, 66);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(321, 23);
            this.txt_usuario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(99, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Usuário conectado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_prioridade
            // 
            this.cb_prioridade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_prioridade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_prioridade.FormattingEnabled = true;
            this.cb_prioridade.Items.AddRange(new object[] {
            "BaixaPrioridade",
            "MediaPrioridade",
            "AltaPrioridade"});
            this.cb_prioridade.Location = new System.Drawing.Point(99, 306);
            this.cb_prioridade.Name = "cb_prioridade";
            this.cb_prioridade.Size = new System.Drawing.Size(320, 23);
            this.cb_prioridade.TabIndex = 4;
            this.cb_prioridade.Tag = "campoCriarTarefa";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(99, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prioridade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_dataVencimento
            // 
            this.dtp_dataVencimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataVencimento.Location = new System.Drawing.Point(98, 254);
            this.dtp_dataVencimento.Name = "dtp_dataVencimento";
            this.dtp_dataVencimento.Size = new System.Drawing.Size(321, 23);
            this.dtp_dataVencimento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(99, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Termina em";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rctxt_descricao
            // 
            this.rctxt_descricao.Location = new System.Drawing.Point(98, 170);
            this.rctxt_descricao.Name = "rctxt_descricao";
            this.rctxt_descricao.Size = new System.Drawing.Size(321, 55);
            this.rctxt_descricao.TabIndex = 2;
            this.rctxt_descricao.Tag = "campoCriarTarefa";
            this.rctxt_descricao.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(98, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição da Tarefa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nomeTarefa
            // 
            this.txt_nomeTarefa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomeTarefa.Location = new System.Drawing.Point(98, 118);
            this.txt_nomeTarefa.Name = "txt_nomeTarefa";
            this.txt_nomeTarefa.Size = new System.Drawing.Size(321, 23);
            this.txt_nomeTarefa.TabIndex = 1;
            this.txt_nomeTarefa.Tag = "campoCriarTarefa";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Tarefa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adicionar.Location = new System.Drawing.Point(99, 335);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(320, 55);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // CriarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarTarefas";
            this.Text = "CriarTarefas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txt_nomeTarefa;
        private Label label1;
        private Button btn_adicionar;
        private RichTextBox rctxt_descricao;
        private Label label2;
        private ComboBox cb_prioridade;
        private Label label4;
        private DateTimePicker dtp_dataVencimento;
        private Label label3;
        private TextBox txt_usuario;
        private Label label5;
    }
}