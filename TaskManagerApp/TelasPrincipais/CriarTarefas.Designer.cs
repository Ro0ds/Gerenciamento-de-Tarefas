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
            panel1 = new Panel();
            txt_usuario = new TextBox();
            label5 = new Label();
            cb_prioridade = new ComboBox();
            label4 = new Label();
            dtp_dataVencimento = new DateTimePicker();
            label3 = new Label();
            rctxt_descricao = new RichTextBox();
            label2 = new Label();
            txt_nomeTarefa = new TextBox();
            label1 = new Label();
            btn_adicionar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cb_prioridade);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtp_dataVencimento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rctxt_descricao);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nomeTarefa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_adicionar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 410);
            panel1.TabIndex = 9999;
            // 
            // txt_usuario
            // 
            txt_usuario.CharacterCasing = CharacterCasing.Upper;
            txt_usuario.Enabled = false;
            txt_usuario.Location = new Point(99, 66);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.ReadOnly = true;
            txt_usuario.Size = new Size(321, 23);
            txt_usuario.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(99, 40);
            label5.Name = "label5";
            label5.Size = new Size(321, 23);
            label5.TabIndex = 8;
            label5.Text = "Usuário conectado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_prioridade
            // 
            cb_prioridade.AutoCompleteMode = AutoCompleteMode.Append;
            cb_prioridade.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_prioridade.FormattingEnabled = true;
            cb_prioridade.Items.AddRange(new object[] { "BaixaPrioridade", "MediaPrioridade", "AltaPrioridade" });
            cb_prioridade.Location = new Point(99, 306);
            cb_prioridade.Name = "cb_prioridade";
            cb_prioridade.Size = new Size(320, 23);
            cb_prioridade.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(99, 280);
            label4.Name = "label4";
            label4.Size = new Size(321, 23);
            label4.TabIndex = 6;
            label4.Text = "Prioridade";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_dataVencimento
            // 
            dtp_dataVencimento.DropDownAlign = LeftRightAlignment.Right;
            dtp_dataVencimento.Format = DateTimePickerFormat.Short;
            dtp_dataVencimento.Location = new Point(98, 254);
            dtp_dataVencimento.Name = "dtp_dataVencimento";
            dtp_dataVencimento.Size = new Size(321, 23);
            dtp_dataVencimento.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(99, 228);
            label3.Name = "label3";
            label3.Size = new Size(321, 23);
            label3.TabIndex = 4;
            label3.Text = "Termina em";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rctxt_descricao
            // 
            rctxt_descricao.Location = new Point(98, 170);
            rctxt_descricao.Name = "rctxt_descricao";
            rctxt_descricao.Size = new Size(321, 55);
            rctxt_descricao.TabIndex = 2;
            rctxt_descricao.Text = "";
            // 
            // label2
            // 
            label2.Location = new Point(98, 144);
            label2.Name = "label2";
            label2.Size = new Size(321, 23);
            label2.TabIndex = 2;
            label2.Text = "Descrição da Tarefa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_nomeTarefa
            // 
            txt_nomeTarefa.CharacterCasing = CharacterCasing.Upper;
            txt_nomeTarefa.Location = new Point(98, 118);
            txt_nomeTarefa.Name = "txt_nomeTarefa";
            txt_nomeTarefa.Size = new Size(321, 23);
            txt_nomeTarefa.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(98, 92);
            label1.Name = "label1";
            label1.Size = new Size(321, 23);
            label1.TabIndex = 1;
            label1.Text = "Nome da Tarefa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adicionar.Location = new Point(99, 335);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(320, 55);
            btn_adicionar.TabIndex = 5;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // CriarTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 434);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CriarTarefas";
            Text = "CriarTarefas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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