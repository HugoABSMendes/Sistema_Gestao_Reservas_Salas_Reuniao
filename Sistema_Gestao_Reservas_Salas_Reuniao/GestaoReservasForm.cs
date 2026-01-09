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
    public partial class GestaoReservasForm : Form
    {
        SqlConnector sqlConnector = new SqlConnector();
        List<FuncionarioModel> funcionarios; 

        private DateTime DataInicio = new DateTime();
        private DateTime DataFim = new DateTime();

        public GestaoReservasForm()
        {
            InitializeComponent();
            dtp_dataInicioReserva.CustomFormat = "MM/dd/yyyy                        HH:mm:ss";
            dtp_dataFimReserva.CustomFormat = "MM/dd/yyyy                       HH:mm:ss";

            funcionarios = sqlConnector.ListarFuncionarios();

            InstanciarVariaveisDoForm();


        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstanciarVariaveisDoForm()
        {
            DataInicio = dtp_dataInicioReserva.Value;
            DataFim = dtp_dataFimReserva.Value;

            lb_funcionario.DataSource = null;
            lb_funcionario.DataSource = funcionarios;
            lb_funcionario.DisplayMember = "nome";

        }




        private void dtp_dataInicioReserva_ValueChanged(object sender, EventArgs e)
        {

            if (dtp_dataInicioReserva.Value >= dtp_dataFimReserva.Value)
            {
                MessageBox.Show("A data do inicio da reserva não pode ser maior que a data do Final da reserva.");
                dtp_dataInicioReserva.Value = DataInicio;
            }

        }

        private void dtp_dataFimReserva_ValueChanged(object sender, EventArgs e)
        {

            if (dtp_dataInicioReserva.Value >= dtp_dataFimReserva.Value)
            {
                MessageBox.Show("A data do inicio da reserva não pode ser maior que a data do Final da reserva.");
                dtp_dataFimReserva.Value = DataFim;
            }

        }

        private void btn_editarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioModel selecionado = (FuncionarioModel)lb_funcionario.SelectedItem;

            GestaoFuncionariosForm frm = new GestaoFuncionariosForm(selecionado);
            frm.Show();
        }

        
    }
}
