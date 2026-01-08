using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    public partial class GestaoReservasForm : Form
    {

        private DateTime DataInicio = new DateTime();
        private DateTime DataFim = new DateTime();
        private string HoraInicio;
        private string HoraFim;

        public GestaoReservasForm()
        {
            InitializeComponent();

            InstanciarVariaveisDoForm();


        }

        private void InstanciarVariaveisDoForm()
        {
            DataInicio = dtp_dataInicioReserva.Value;
            DataFim = dtp_dataFimReserva.Value;
            HoraInicio = dtp_horaInicioReserva.Value.ToString("HH:mm:ss");
            HoraFim = dtp_horaFimReserva.Value.ToString("HH:mm:ss");
        }




        private void dtp_dataInicioReserva_ValueChanged(object sender, EventArgs e)
        {

            if (dtp_dataInicioReserva.Value >= dtp_dataFimReserva.Value)
            {
                MessageBox.Show("NO!");
                dtp_dataInicioReserva.Value = DataInicio;
            }

        }

        private void dtp_dataFimReserva_ValueChanged(object sender, EventArgs e)
        {

            if ()

        }
    }
}
