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
using System.Text.RegularExpressions;

namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    public partial class GestaoFuncionariosForm : Form
    {
        bool editar;
        string textoMessageBox = string.Empty;
        SqlConnector sqlConnector = new SqlConnector();

        FuncionarioModel funcionarioAEditar;
        GestaoReservasForm formAnterior;

        public GestaoFuncionariosForm(GestaoReservasForm gRF)
        {
            InitializeComponent();
            editar = false;

            formAnterior = gRF;
        }

        public GestaoFuncionariosForm(FuncionarioModel selecionado, GestaoReservasForm gRF)
        {
            InitializeComponent();
            editar = true;

            funcionarioAEditar = selecionado;
            formAnterior = gRF;

            tb_nomeFuncionario.Text = funcionarioAEditar.Nome;
            tb_emailFuncionario.Text = funcionarioAEditar.Email;
            tb_departamentoFuncionario.Text = funcionarioAEditar.Departamento;
        }

        private void btn_cancelarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_criarNovoFuncionario_Click(object sender, EventArgs e)
        {

            if (ValidarForm())
            {
                if (editar == false) //Se for um novo Funcionari
                {
                    FuncionarioModel model = new FuncionarioModel(tb_nomeFuncionario.Text, tb_emailFuncionario.Text, tb_departamentoFuncionario.Text);

                    sqlConnector.AdicionarFuncionario(model);
                    formAnterior.WireUpLists();

                    this.Close();

                }
                else //Editar funcionario
                {
                    FuncionarioModel model = new FuncionarioModel(funcionarioAEditar.IdFuncionario,tb_nomeFuncionario.Text, tb_emailFuncionario.Text,
                        tb_departamentoFuncionario.Text);

                    sqlConnector.AtualizarFuncionario(model);
                    formAnterior.WireUpLists();

                    this.Close();

                }

            }
            else
            {
                MessageBox.Show(textoMessageBox, "Erro!");
            }    

        }

        private bool ValidarForm()
        {
            bool output = true;

            if (tb_nomeFuncionario.Text.Length == 0)
            {
                output = false;
                textoMessageBox = "O nome do funcionário não pode ser nulo!";
            }
            if (tb_emailFuncionario.Text.Length == 0)
            {
                output = false;
                textoMessageBox = "O email do funcionário não pode ser nulo!";
            }
            if (tb_departamentoFuncionario.Text.Length == 0)
            {
                output = false;
                textoMessageBox = "O departamento do funcionário não pode ser nulo!";
            }

            string verificarEmail = @"^[^@]+@[^@]+\.[^@]+$";

            if (Regex.IsMatch(tb_emailFuncionario.Text,verificarEmail) == false)
            {
                output = false;
                textoMessageBox = "O email do funcionário é invalido! Certifique-se que a formatação é valida e tente outra vez.";
            }

            return output;
        }


    }
}
