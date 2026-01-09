namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    partial class GestaoFuncionariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoFuncionariosForm));
            label3 = new Label();
            tb_nomeFuncionario = new TextBox();
            tb_emailFuncionario = new TextBox();
            label1 = new Label();
            tb_departamentoFuncionario = new TextBox();
            label2 = new Label();
            btn_criarNovoFuncionario = new Button();
            btn_cancelarFuncionario = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonShadow;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(191, 46);
            label3.TabIndex = 16;
            label3.Text = "Nome do Funcionário:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_nomeFuncionario
            // 
            tb_nomeFuncionario.BackColor = SystemColors.InactiveBorder;
            tb_nomeFuncionario.Location = new Point(209, 22);
            tb_nomeFuncionario.MaxLength = 49;
            tb_nomeFuncionario.Name = "tb_nomeFuncionario";
            tb_nomeFuncionario.Size = new Size(259, 25);
            tb_nomeFuncionario.TabIndex = 17;
            tb_nomeFuncionario.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_emailFuncionario
            // 
            tb_emailFuncionario.BackColor = SystemColors.InactiveBorder;
            tb_emailFuncionario.Location = new Point(209, 119);
            tb_emailFuncionario.MaxLength = 49;
            tb_emailFuncionario.Name = "tb_emailFuncionario";
            tb_emailFuncionario.Size = new Size(259, 25);
            tb_emailFuncionario.TabIndex = 19;
            tb_emailFuncionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonShadow;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 18;
            label1.Text = "Email do Funcionário:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_departamentoFuncionario
            // 
            tb_departamentoFuncionario.BackColor = SystemColors.InactiveBorder;
            tb_departamentoFuncionario.Location = new Point(209, 216);
            tb_departamentoFuncionario.MaxLength = 49;
            tb_departamentoFuncionario.Name = "tb_departamentoFuncionario";
            tb_departamentoFuncionario.Size = new Size(259, 25);
            tb_departamentoFuncionario.TabIndex = 21;
            tb_departamentoFuncionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonShadow;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 203);
            label2.Name = "label2";
            label2.Size = new Size(191, 46);
            label2.TabIndex = 20;
            label2.Text = "Departamento:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_criarNovoFuncionario
            // 
            btn_criarNovoFuncionario.BackColor = SystemColors.GradientInactiveCaption;
            btn_criarNovoFuncionario.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criarNovoFuncionario.Location = new Point(12, 303);
            btn_criarNovoFuncionario.Name = "btn_criarNovoFuncionario";
            btn_criarNovoFuncionario.Size = new Size(259, 62);
            btn_criarNovoFuncionario.TabIndex = 22;
            btn_criarNovoFuncionario.Text = "Criar Funcionário";
            btn_criarNovoFuncionario.UseVisualStyleBackColor = false;
            btn_criarNovoFuncionario.Click += btn_criarNovoFuncionario_Click;
            // 
            // btn_cancelarFuncionario
            // 
            btn_cancelarFuncionario.BackColor = SystemColors.GradientInactiveCaption;
            btn_cancelarFuncionario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelarFuncionario.Location = new Point(277, 334);
            btn_cancelarFuncionario.Name = "btn_cancelarFuncionario";
            btn_cancelarFuncionario.Size = new Size(191, 31);
            btn_cancelarFuncionario.TabIndex = 23;
            btn_cancelarFuncionario.Text = "Cancelar";
            btn_cancelarFuncionario.UseVisualStyleBackColor = false;
            btn_cancelarFuncionario.Click += btn_cancelarFuncionario_Click;
            // 
            // GestaoFuncionariosForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(480, 376);
            Controls.Add(btn_cancelarFuncionario);
            Controls.Add(btn_criarNovoFuncionario);
            Controls.Add(tb_departamentoFuncionario);
            Controls.Add(label2);
            Controls.Add(tb_emailFuncionario);
            Controls.Add(label1);
            Controls.Add(tb_nomeFuncionario);
            Controls.Add(label3);
            Font = new Font("Arial", 11.25F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestaoFuncionariosForm";
            Text = "GestaoFuncionariosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tb_nomeFuncionario;
        private TextBox tb_emailFuncionario;
        private Label label1;
        private TextBox tb_departamentoFuncionario;
        private Label label2;
        private Button btn_criarNovoFuncionario;
        private Button btn_cancelarFuncionario;
    }
}