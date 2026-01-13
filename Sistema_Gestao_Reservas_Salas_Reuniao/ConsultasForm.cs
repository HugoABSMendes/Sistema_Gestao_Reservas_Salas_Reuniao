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

            WireUpReservas();
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
            if (lb_reserva.SelectedItem != null)
            {
                ReservaModel selecionado = (ReservaModel)lb_reserva.SelectedItem;

                sqlConnector.CancelarReserva(selecionado);

                WireUpReservas();
            }
            else
            {
                MessageBox.Show("Não existe nenhuma reserva a apagar!","Erro!");
            }

            
        }

        private void WireUpReservas()
        {
            if (cb_ordenarSala.Checked && cb_ordenarFuncionario.Checked == false) // Apenas checkBox sala checked
            {

                SalaModel selecionado = (SalaModel)combox_SalaFuncionario.SelectedItem;
                reservas = sqlConnector.ListarReservasPorSala(selecionado);

                lb_reserva.DataSource = null;
                lb_reserva.DataSource = reservas;
                lb_reserva.DisplayMember = "DescricaoPorSala";


                btn_apagarReserva.Enabled = true;
            }
            else if (cb_ordenarFuncionario.Checked && cb_ordenarSala.Checked == false) // Apenas checkBox funcionario checked
            {

                FuncionarioModel selecionado = (FuncionarioModel)combox_SalaFuncionario.SelectedItem;
                reservas = sqlConnector.ListarReservasPorFuncionario(selecionado);

                lb_reserva.DataSource = null;
                lb_reserva.DataSource = reservas;
                lb_reserva.DisplayMember = "DescricaoPorFuncionario";


                btn_apagarReserva.Enabled = true;
            }
            else // Nenhum tiver checked / etc?
            {
                lb_reserva.DataSource = null;
                btn_apagarReserva.Enabled = false;
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
