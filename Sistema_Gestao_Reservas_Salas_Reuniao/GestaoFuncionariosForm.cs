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
        SqlConnector sqlConnector = new SqlConnector();

        FuncionarioModel funcionarioAEditar;

        public GestaoFuncionariosForm()
        {
            InitializeComponent();
            editar = false;
        }

        public GestaoFuncionariosForm(FuncionarioModel selecionado)
        {
            InitializeComponent();
            editar = true;

            funcionarioAEditar = selecionado;

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

                    this.Close();

                }
                else //Editar funcionario
                {
                    FuncionarioModel model = new FuncionarioModel(funcionarioAEditar.IdFuncionario,tb_nomeFuncionario.Text, tb_emailFuncionario.Text,
                        tb_departamentoFuncionario.Text);

                    sqlConnector.AtualizarFuncionario(model);

                    this.Close();

                }

            }
            else
            {
                MessageBox.Show("Algo está de errado no form. Por favor, valide o texto e tente novamente.");
            }    

        }

        private bool ValidarForm()
        {
            bool output = true;

            if (tb_nomeFuncionario.Text.Length == 0)
            {
                output = false;
            }
            if (tb_emailFuncionario.Text.Length == 0)
            {
                output = false;
            }
            if (tb_departamentoFuncionario.Text.Length == 0)
            {
                output = false;
            }

            string verificarEmail = @"^[^@]+@[^@]+\.[^@]+$";

            if (Regex.IsMatch(tb_emailFuncionario.Text,verificarEmail) == false)
            {
                output = false;
            }

            return output;
        }


    }
}
