namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    partial class GestaoReservasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoReservasForm));
            lb_funcionario = new ListBox();
            lb_sala = new ListBox();
            btn_editarFuncionario = new Button();
            btn_apagarFuncionario = new Button();
            btn_criarFuncionario = new Button();
            btn_editarSala = new Button();
            btn_apagarSala = new Button();
            btn_criarSala = new Button();
            btn_criarReserva = new Button();
            dtp_dataInicioReserva = new DateTimePicker();
            dtp_horaInicioReserva = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtp_horaFimReserva = new DateTimePicker();
            dtp_dataFimReserva = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // lb_funcionario
            // 
            lb_funcionario.FormattingEnabled = true;
            lb_funcionario.ItemHeight = 18;
            lb_funcionario.Location = new Point(12, 199);
            lb_funcionario.Name = "lb_funcionario";
            lb_funcionario.Size = new Size(333, 346);
            lb_funcionario.TabIndex = 0;
            // 
            // lb_sala
            // 
            lb_sala.FormattingEnabled = true;
            lb_sala.ItemHeight = 18;
            lb_sala.Location = new Point(617, 199);
            lb_sala.Name = "lb_sala";
            lb_sala.Size = new Size(333, 346);
            lb_sala.TabIndex = 1;
            // 
            // btn_editarFuncionario
            // 
            btn_editarFuncionario.BackColor = SystemColors.GradientInactiveCaption;
            btn_editarFuncionario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editarFuncionario.Location = new Point(12, 153);
            btn_editarFuncionario.Name = "btn_editarFuncionario";
            btn_editarFuncionario.Size = new Size(111, 40);
            btn_editarFuncionario.TabIndex = 2;
            btn_editarFuncionario.Text = "Editar";
            btn_editarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btn_apagarFuncionario
            // 
            btn_apagarFuncionario.BackColor = SystemColors.GradientInactiveCaption;
            btn_apagarFuncionario.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_apagarFuncionario.Location = new Point(234, 153);
            btn_apagarFuncionario.Name = "btn_apagarFuncionario";
            btn_apagarFuncionario.Size = new Size(111, 40);
            btn_apagarFuncionario.TabIndex = 3;
            btn_apagarFuncionario.Text = "Apagar";
            btn_apagarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btn_criarFuncionario
            // 
            btn_criarFuncionario.BackColor = SystemColors.GradientInactiveCaption;
            btn_criarFuncionario.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btn_criarFuncionario.Location = new Point(12, 107);
            btn_criarFuncionario.Name = "btn_criarFuncionario";
            btn_criarFuncionario.Size = new Size(333, 40);
            btn_criarFuncionario.TabIndex = 4;
            btn_criarFuncionario.Text = "Criar";
            btn_criarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btn_editarSala
            // 
            btn_editarSala.BackColor = SystemColors.GradientInactiveCaption;
            btn_editarSala.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_editarSala.Location = new Point(617, 153);
            btn_editarSala.Name = "btn_editarSala";
            btn_editarSala.Size = new Size(111, 40);
            btn_editarSala.TabIndex = 5;
            btn_editarSala.Text = "Editar";
            btn_editarSala.UseVisualStyleBackColor = false;
            // 
            // btn_apagarSala
            // 
            btn_apagarSala.BackColor = SystemColors.GradientInactiveCaption;
            btn_apagarSala.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_apagarSala.Location = new Point(839, 153);
            btn_apagarSala.Name = "btn_apagarSala";
            btn_apagarSala.Size = new Size(111, 40);
            btn_apagarSala.TabIndex = 6;
            btn_apagarSala.Text = "Apagar";
            btn_apagarSala.UseVisualStyleBackColor = false;
            // 
            // btn_criarSala
            // 
            btn_criarSala.BackColor = SystemColors.GradientInactiveCaption;
            btn_criarSala.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criarSala.Location = new Point(617, 107);
            btn_criarSala.Name = "btn_criarSala";
            btn_criarSala.Size = new Size(333, 40);
            btn_criarSala.TabIndex = 7;
            btn_criarSala.Text = "Criar";
            btn_criarSala.UseVisualStyleBackColor = false;
            // 
            // btn_criarReserva
            // 
            btn_criarReserva.BackColor = SystemColors.GradientActiveCaption;
            btn_criarReserva.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_criarReserva.Location = new Point(349, 423);
            btn_criarReserva.Name = "btn_criarReserva";
            btn_criarReserva.Size = new Size(262, 79);
            btn_criarReserva.TabIndex = 8;
            btn_criarReserva.Text = "Criar Reserva";
            btn_criarReserva.UseVisualStyleBackColor = false;
            // 
            // dtp_dataInicioReserva
            // 
            dtp_dataInicioReserva.Format = DateTimePickerFormat.Short;
            dtp_dataInicioReserva.Location = new Point(351, 279);
            dtp_dataInicioReserva.Name = "dtp_dataInicioReserva";
            dtp_dataInicioReserva.Size = new Size(126, 25);
            dtp_dataInicioReserva.TabIndex = 9;
            // 
            // dtp_horaInicioReserva
            // 
            dtp_horaInicioReserva.Format = DateTimePickerFormat.Time;
            dtp_horaInicioReserva.Location = new Point(485, 279);
            dtp_horaInicioReserva.Name = "dtp_horaInicioReserva";
            dtp_horaInicioReserva.Size = new Size(126, 25);
            dtp_horaInicioReserva.TabIndex = 10;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonShadow;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(351, 228);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 11;
            label1.Text = "Hora do Inicio da Reserva:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonShadow;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(351, 341);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 14;
            label2.Text = "Hora do Fim da Reserva:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_horaFimReserva
            // 
            dtp_horaFimReserva.Format = DateTimePickerFormat.Time;
            dtp_horaFimReserva.Location = new Point(485, 392);
            dtp_horaFimReserva.Name = "dtp_horaFimReserva";
            dtp_horaFimReserva.Size = new Size(126, 25);
            dtp_horaFimReserva.TabIndex = 13;
            // 
            // dtp_dataFimReserva
            // 
            dtp_dataFimReserva.Format = DateTimePickerFormat.Short;
            dtp_dataFimReserva.Location = new Point(351, 392);
            dtp_dataFimReserva.Name = "dtp_dataFimReserva";
            dtp_dataFimReserva.Size = new Size(126, 25);
            dtp_dataFimReserva.TabIndex = 12;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonShadow;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(333, 68);
            label3.TabIndex = 15;
            label3.Text = "Funcionários:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonShadow;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(617, 9);
            label4.Name = "label4";
            label4.Size = new Size(333, 68);
            label4.TabIndex = 16;
            label4.Text = "Salas:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientInactiveCaption;
            btn_voltar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_voltar.Location = new Point(351, 508);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(260, 37);
            btn_voltar.TabIndex = 17;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            // 
            // GestaoReservasForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(962, 555);
            Controls.Add(btn_voltar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtp_horaFimReserva);
            Controls.Add(dtp_dataFimReserva);
            Controls.Add(label1);
            Controls.Add(dtp_horaInicioReserva);
            Controls.Add(dtp_dataInicioReserva);
            Controls.Add(btn_criarReserva);
            Controls.Add(btn_criarSala);
            Controls.Add(btn_apagarSala);
            Controls.Add(btn_editarSala);
            Controls.Add(btn_criarFuncionario);
            Controls.Add(btn_apagarFuncionario);
            Controls.Add(btn_editarFuncionario);
            Controls.Add(lb_sala);
            Controls.Add(lb_funcionario);
            Font = new Font("Arial", 11.25F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestaoReservasForm";
            Text = "GestaoReservasForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_funcionario;
        private ListBox lb_sala;
        private Button btn_editarFuncionario;
        private Button btn_apagarFuncionario;
        private Button btn_criarFuncionario;
        private Button btn_editarSala;
        private Button btn_apagarSala;
        private Button btn_criarSala;
        private Button btn_criarReserva;
        private DateTimePicker dtp_dataInicioReserva;
        private DateTimePicker dtp_horaInicioReserva;
        private Label label1;
        private Label label2;
        private DateTimePicker dtp_horaFimReserva;
        private DateTimePicker dtp_dataFimReserva;
        private Label label3;
        private Label label4;
        private Button btn_voltar;
    }
}