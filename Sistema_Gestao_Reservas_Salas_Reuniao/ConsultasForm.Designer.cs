namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    partial class ConsultasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasForm));
            lb_reserva = new ListBox();
            btn_criarReserva = new Button();
            btn_apagarReserva = new Button();
            cb_ordenarFuncionario = new CheckBox();
            cb_ordenarSala = new CheckBox();
            combox_SalaFuncionario = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lb_reserva
            // 
            lb_reserva.FormattingEnabled = true;
            lb_reserva.ItemHeight = 18;
            lb_reserva.Location = new Point(12, 70);
            lb_reserva.Name = "lb_reserva";
            lb_reserva.Size = new Size(754, 346);
            lb_reserva.TabIndex = 0;
            // 
            // btn_criarReserva
            // 
            btn_criarReserva.BackColor = SystemColors.GradientInactiveCaption;
            btn_criarReserva.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criarReserva.Location = new Point(12, 519);
            btn_criarReserva.Name = "btn_criarReserva";
            btn_criarReserva.Size = new Size(202, 67);
            btn_criarReserva.TabIndex = 1;
            btn_criarReserva.Text = "Criar Nova Reserva";
            btn_criarReserva.UseVisualStyleBackColor = false;
            btn_criarReserva.Click += btn_criarReserva_Click;
            // 
            // btn_apagarReserva
            // 
            btn_apagarReserva.BackColor = SystemColors.GradientInactiveCaption;
            btn_apagarReserva.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_apagarReserva.Location = new Point(564, 519);
            btn_apagarReserva.Name = "btn_apagarReserva";
            btn_apagarReserva.Size = new Size(202, 67);
            btn_apagarReserva.TabIndex = 2;
            btn_apagarReserva.Text = "Apagar Reserva";
            btn_apagarReserva.UseVisualStyleBackColor = false;
            btn_apagarReserva.Click += btn_apagarReserva_Click;
            // 
            // cb_ordenarFuncionario
            // 
            cb_ordenarFuncionario.Location = new Point(564, 422);
            cb_ordenarFuncionario.Name = "cb_ordenarFuncionario";
            cb_ordenarFuncionario.RightToLeft = RightToLeft.Yes;
            cb_ordenarFuncionario.Size = new Size(202, 22);
            cb_ordenarFuncionario.TabIndex = 3;
            cb_ordenarFuncionario.Text = "Ordenar por Funcionario";
            cb_ordenarFuncionario.UseVisualStyleBackColor = true;
            cb_ordenarFuncionario.CheckedChanged += cb_ordenarFuncionario_CheckedChanged;
            // 
            // cb_ordenarSala
            // 
            cb_ordenarSala.Location = new Point(12, 422);
            cb_ordenarSala.Name = "cb_ordenarSala";
            cb_ordenarSala.Size = new Size(202, 22);
            cb_ordenarSala.TabIndex = 4;
            cb_ordenarSala.Text = "Ordenar por Sala";
            cb_ordenarSala.UseVisualStyleBackColor = true;
            cb_ordenarSala.CheckedChanged += cb_ordenarSala_CheckedChanged;
            // 
            // combox_SalaFuncionario
            // 
            combox_SalaFuncionario.FormattingEnabled = true;
            combox_SalaFuncionario.Location = new Point(12, 450);
            combox_SalaFuncionario.Name = "combox_SalaFuncionario";
            combox_SalaFuncionario.Size = new Size(754, 26);
            combox_SalaFuncionario.TabIndex = 5;
            combox_SalaFuncionario.SelectedIndexChanged += combox_SalaFuncionario_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonShadow;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(754, 50);
            label3.TabIndex = 16;
            label3.Text = "Reservas de Salas:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConsultasForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(778, 598);
            Controls.Add(label3);
            Controls.Add(combox_SalaFuncionario);
            Controls.Add(cb_ordenarSala);
            Controls.Add(cb_ordenarFuncionario);
            Controls.Add(btn_apagarReserva);
            Controls.Add(btn_criarReserva);
            Controls.Add(lb_reserva);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultasForm";
            Text = "ConsultasForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_reserva;
        private Button btn_criarReserva;
        private Button btn_apagarReserva;
        private CheckBox cb_ordenarFuncionario;
        private CheckBox cb_ordenarSala;
        private ComboBox combox_SalaFuncionario;
        private Label label3;
    }
}