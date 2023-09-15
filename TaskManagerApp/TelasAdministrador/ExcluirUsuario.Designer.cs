namespace TaskManagerApp.TelasAdministrador
{
    partial class ExcluirUsuario
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
            gridUsuarios = new DataGridView();
            btn_deletar = new Button();
            label1 = new Label();
            btn_atualizar = new Button();
            txt_codUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Dock = DockStyle.Top;
            gridUsuarios.Location = new Point(0, 0);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowTemplate.Height = 25;
            gridUsuarios.Size = new Size(876, 234);
            gridUsuarios.TabIndex = 10000;
            // 
            // btn_deletar
            // 
            btn_deletar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deletar.Location = new Point(468, 249);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(78, 30);
            btn_deletar.TabIndex = 10001;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = true;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 246);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 10002;
            label1.Text = "Código do Usuário";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_atualizar.Location = new Point(552, 249);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(78, 30);
            btn_atualizar.TabIndex = 10003;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // txt_codUsuario
            // 
            txt_codUsuario.Location = new Point(395, 253);
            txt_codUsuario.Name = "txt_codUsuario";
            txt_codUsuario.Size = new Size(67, 23);
            txt_codUsuario.TabIndex = 10004;
            // 
            // ExcluirUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 312);
            Controls.Add(txt_codUsuario);
            Controls.Add(btn_atualizar);
            Controls.Add(label1);
            Controls.Add(btn_deletar);
            Controls.Add(gridUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExcluirUsuario";
            Text = "ExcluirUsuario";
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridUsuarios;
        private Button btn_deletar;
        private Label label1;
        private Button btn_atualizar;
        private TextBox txt_codUsuario;
    }
}