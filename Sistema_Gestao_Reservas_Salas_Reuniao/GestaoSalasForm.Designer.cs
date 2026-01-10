namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    partial class GestaoSalasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoSalasForm));
            btn_cancelarSala = new Button();
            btn_criarNovaSala = new Button();
            tb_localizaçãoSala = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_nomeSala = new TextBox();
            label3 = new Label();
            nud_capacidadeSala = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_capacidadeSala).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelarSala
            // 
            btn_cancelarSala.BackColor = SystemColors.GradientInactiveCaption;
            btn_cancelarSala.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelarSala.Location = new Point(277, 335);
            btn_cancelarSala.Name = "btn_cancelarSala";
            btn_cancelarSala.Size = new Size(191, 31);
            btn_cancelarSala.TabIndex = 31;
            btn_cancelarSala.Text = "Cancelar";
            btn_cancelarSala.UseVisualStyleBackColor = false;
            btn_cancelarSala.Click += btn_cancelarSala_Click;
            // 
            // btn_criarNovaSala
            // 
            btn_criarNovaSala.BackColor = SystemColors.GradientInactiveCaption;
            btn_criarNovaSala.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criarNovaSala.Location = new Point(12, 304);
            btn_criarNovaSala.Name = "btn_criarNovaSala";
            btn_criarNovaSala.Size = new Size(259, 62);
            btn_criarNovaSala.TabIndex = 30;
            btn_criarNovaSala.Text = "Criar Nova Sala";
            btn_criarNovaSala.UseVisualStyleBackColor = false;
            btn_criarNovaSala.Click += btn_criarNovaSala_Click;
            // 
            // tb_localizaçãoSala
            // 
            tb_localizaçãoSala.BackColor = SystemColors.InactiveBorder;
            tb_localizaçãoSala.Location = new Point(209, 217);
            tb_localizaçãoSala.MaxLength = 49;
            tb_localizaçãoSala.Name = "tb_localizaçãoSala";
            tb_localizaçãoSala.Size = new Size(259, 25);
            tb_localizaçãoSala.TabIndex = 29;
            tb_localizaçãoSala.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonShadow;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 204);
            label2.Name = "label2";
            label2.Size = new Size(191, 46);
            label2.TabIndex = 28;
            label2.Text = "Localização:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonShadow;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 26;
            label1.Text = "Capacidade da Sala:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_nomeSala
            // 
            tb_nomeSala.BackColor = SystemColors.InactiveBorder;
            tb_nomeSala.Location = new Point(209, 23);
            tb_nomeSala.MaxLength = 49;
            tb_nomeSala.Name = "tb_nomeSala";
            tb_nomeSala.Size = new Size(259, 25);
            tb_nomeSala.TabIndex = 25;
            tb_nomeSala.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonShadow;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(191, 46);
            label3.TabIndex = 24;
            label3.Text = "Nome da Sala:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nud_capacidadeSala
            // 
            nud_capacidadeSala.BackColor = SystemColors.InactiveBorder;
            nud_capacidadeSala.BorderStyle = BorderStyle.FixedSingle;
            nud_capacidadeSala.Location = new Point(209, 121);
            nud_capacidadeSala.Name = "nud_capacidadeSala";
            nud_capacidadeSala.Size = new Size(259, 25);
            nud_capacidadeSala.TabIndex = 32;
            nud_capacidadeSala.TextAlign = HorizontalAlignment.Right;
            // 
            // GestaoSalasForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(480, 376);
            Controls.Add(nud_capacidadeSala);
            Controls.Add(btn_cancelarSala);
            Controls.Add(btn_criarNovaSala);
            Controls.Add(tb_localizaçãoSala);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nomeSala);
            Controls.Add(label3);
            Font = new Font("Arial", 11.25F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestaoSalasForm";
            Text = "GestaoSalasForm";
            ((System.ComponentModel.ISupportInitialize)nud_capacidadeSala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelarSala;
        private Button btn_criarNovaSala;
        private TextBox tb_localizaçãoSala;
        private Label label2;
        private Label label1;
        private TextBox tb_nomeSala;
        private Label label3;
        private NumericUpDown nud_capacidadeSala;
    }
}