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
        List<SalaModel> salas;

        private DateTime DataInicio = new DateTime();
        private DateTime DataFim = new DateTime();

        public GestaoReservasForm()
        {
            InitializeComponent();
            dtp_dataInicioReserva.CustomFormat = "MM/dd/yyyy                        HH:mm:ss";
            dtp_dataFimReserva.CustomFormat = "MM/dd/yyyy                       HH:mm:ss";


            InstanciarVariaveisDoForm();

            WireUpLists();


        }

        public void WireUpLists()
        {
            //---Funcionarios---
            funcionarios = sqlConnector.ListarFuncionarios();

            lb_funcionario.DataSource = null;
            lb_funcionario.DataSource = funcionarios;
            lb_funcionario.DisplayMember = "nome";

            if (funcionarios.Count == 0)
            {
                btn_editarFuncionario.Enabled = false;
                btn_apagarFuncionario.Enabled = false;
            }
            else
            {
                btn_editarFuncionario.Enabled = true;
                btn_apagarFuncionario.Enabled = true;
            }

            //---Salas---
            salas = sqlConnector.ListarSalas();

            lb_sala.DataSource = null;
            lb_sala.DataSource = salas;
            lb_sala.DisplayMember = "Nome";

            if (salas.Count == 0)
            {
                btn_editarSala.Enabled = false;
                btn_apagarSala.Enabled = false;
            }
            else
            {
                btn_editarSala.Enabled = true;
                btn_apagarSala.Enabled = true;
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstanciarVariaveisDoForm()
        {
            DataInicio = dtp_dataInicioReserva.Value;
            DataFim = dtp_dataFimReserva.Value;
        }


        private void dtp_dataInicioReserva_ValueChanged(object sender, EventArgs e)
        {

            if (dtp_dataInicioReserva.Value >= dtp_dataFimReserva.Value)
            {
                MessageBox.Show("A data do inicio da reserva não pode ser maior que a data do Final da reserva.", "Erro!");
                dtp_dataInicioReserva.Value = DataInicio;
            }

        }

        private void dtp_dataFimReserva_ValueChanged(object sender, EventArgs e)
        {

            if (dtp_dataInicioReserva.Value >= dtp_dataFimReserva.Value)
            {
                MessageBox.Show("A data do inicio da reserva não pode ser maior que a data do Final da reserva.", "Erro!");
                dtp_dataFimReserva.Value = DataFim;
            }

        }

        //---------

        private void btn_editarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioModel selecionado = (FuncionarioModel)lb_funcionario.SelectedItem;

            GestaoFuncionariosForm frm = new GestaoFuncionariosForm(selecionado, this);
            frm.Show();
        }

        private void btn_criarFuncionario_Click(object sender, EventArgs e)
        {

            GestaoFuncionariosForm frm = new GestaoFuncionariosForm(this);
            frm.Show();
        }

        private void btn_apagarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioModel selecionado = (FuncionarioModel)lb_funcionario.SelectedItem;

            sqlConnector.RemoverFuncionario(selecionado);
            WireUpLists();
        }

        //---------

        private void btn_criarSala_Click(object sender, EventArgs e)
        {
            GestaoSalasForm frm = new GestaoSalasForm(this);
            frm.Show();
        }

        private void btn_editarSala_Click(object sender, EventArgs e)
        {
            SalaModel selecionado = (SalaModel)lb_sala.SelectedItem;

            GestaoSalasForm frm = new GestaoSalasForm(selecionado, this);
            frm.Show();
        }

        private void btn_apagarSala_Click(object sender, EventArgs e)
        {
            SalaModel selecionado = (SalaModel)lb_sala.SelectedItem;

            sqlConnector.RemoverSala(selecionado);
            WireUpLists();
        }
    }
}
