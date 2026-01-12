using Sistema_Gestao_Reservas_Salas_Reuniao.Modelos;
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
    public partial class ConsultasForm : Form
    {

        SqlConnector sqlConnector = new SqlConnector();
        List<ReservaModel> reservas;

        List<FuncionarioModel> funcionarios;
        List<SalaModel> salas;

        public ConsultasForm()
        {
            InitializeComponent();
        }

        private void cb_ordenarSala_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ordenarSala.Checked)
            {
                if (cb_ordenarFuncionario.Checked != true)
                {
                    salas = sqlConnector.ListarSalas();

                    combox_SalaFuncionario.DataSource = null;
                    combox_SalaFuncionario.DataSource = salas;
                    combox_SalaFuncionario.DisplayMember = "nome";

                }
                else
                {
                    MessageBox.Show("Não podemos ordenar pelas duas maneiras ao mesmo tempo!", "Erro!");
                    cb_ordenarSala.Checked = false;
                }
            }
            else
            {
                if (cb_ordenarFuncionario.Checked == false)
                {
                    lb_reserva.DataSource = null;
                    combox_SalaFuncionario.DataSource = null;
                }
            }
        }

        private void cb_ordenarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ordenarFuncionario.Checked)
            {
                if (cb_ordenarSala.Checked != true)
                {
                    funcionarios = sqlConnector.ListarFuncionarios();

                    combox_SalaFuncionario.DataSource = null;
                    combox_SalaFuncionario.DataSource = funcionarios;
                    combox_SalaFuncionario.DisplayMember = "nome";

                }
                else
                {
                    MessageBox.Show("Não podemos ordenar pelas duas maneiras ao mesmo tempo!", "Erro!");
                    cb_ordenarFuncionario.Checked = false;
                }
            }
            else
            {
                if (cb_ordenarSala.Checked != true)
                {
                    lb_reserva.DataSource = null;
                    combox_SalaFuncionario.DataSource = null;
                }
            }
        }

        private void combox_SalaFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpReservas();
        }

        private void btn_apagarReserva_Click(object sender, EventArgs e)
        {
            ReservaModel selecionado = (ReservaModel)lb_reserva.SelectedItem;

            sqlConnector.CancelarReserva(selecionado);

            WireUpReservas();
        }

        private void WireUpReservas()
        {
            if (cb_ordenarSala.Checked && cb_ordenarFuncionario.Checked == false)
            {

                SalaModel selecionado = (SalaModel)combox_SalaFuncionario.SelectedItem;
                reservas = sqlConnector.ListarReservasPorSala(selecionado);

                lb_reserva.DataSource = null;
                lb_reserva.DataSource = reservas;
                lb_reserva.DisplayMember = "DescricaoPorSala";

            }
            else if (cb_ordenarFuncionario.Checked && cb_ordenarSala.Checked == false)
            {

                FuncionarioModel selecionado = (FuncionarioModel)combox_SalaFuncionario.SelectedItem;
                reservas = sqlConnector.ListarReservasPorFuncionario(selecionado);

                lb_reserva.DataSource = null;
                lb_reserva.DataSource = reservas;
                lb_reserva.DisplayMember = "DescricaoPorFuncionario";

            }
            else
            {
                lb_reserva.DataSource = null;
            }
        }



        private void btn_criarReserva_Click(object sender, EventArgs e)
        {
            GestaoReservasForm frm = new GestaoReservasForm();
            cb_ordenarFuncionario.Checked = false;
            cb_ordenarSala.Checked = false;
            frm.Show();
        }

    }
}
