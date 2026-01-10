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
    public partial class GestaoSalasForm : Form
    {
        bool editar;
        string textoMessageBox = string.Empty;
        SqlConnector sqlConnector = new SqlConnector();

        SalaModel salaAEditar;
        GestaoReservasForm formAnterior;

        public GestaoSalasForm(GestaoReservasForm gRF)
        {
            InitializeComponent();
            editar = false;

            formAnterior = gRF;

        }
        public GestaoSalasForm(SalaModel selecionado, GestaoReservasForm gRF)
        {
            InitializeComponent();
            editar = true;

            salaAEditar = selecionado;
            formAnterior = gRF;

            tb_nomeSala.Text = salaAEditar.Nome;
            tb_localizaçãoSala.Text = salaAEditar.Localizacao;
            nud_capacidadeSala.Value = salaAEditar.Capacidade;

        }

        private void btn_cancelarSala_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_criarNovaSala_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                if (editar == false) //Se for uma nova Sala
                {

                    SalaModel model = new SalaModel(tb_nomeSala.Text, Convert.ToInt32(nud_capacidadeSala.Value), tb_localizaçãoSala.Text);
                    
                    sqlConnector.AdicionarSala(model);
                    formAnterior.WireUpLists();

                    this.Close();

                }
                else //Editar Sala
                {

                    SalaModel model = new SalaModel(salaAEditar.IdSala, tb_nomeSala.Text, Convert.ToInt32(nud_capacidadeSala.Value),
                        tb_localizaçãoSala.Text);

                    sqlConnector.AtualizarSala(model);
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

            if (tb_nomeSala.Text.Length == 0)
            {
                output = false;
                textoMessageBox = "O nome da sala não pode ser nulo!";
            }
            if (tb_localizaçãoSala.Text.Length == 0)
            {
                output = false;
                textoMessageBox = "A localização da sala não pode ser nula!";
            }
            if (nud_capacidadeSala.Value <= 0)
            {
                output = false;
                textoMessageBox = "A capacidade da sala não pode ser menor ou igual a zero!";
            }

            return output;
        }
    }
}
