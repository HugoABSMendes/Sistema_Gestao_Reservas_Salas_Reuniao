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
using System.Xml;

namespace Sistema_Gestao_Reservas_Salas_Reuniao
{
    public partial class GestaoReservasForm : Form
    {
        SqlConnector sqlConnector = new SqlConnector();
        List<FuncionarioModel> funcionarios;
        List<SalaModel> salas;

        public GestaoReservasForm()
        {
            InitializeComponent();
            dtp_dataInicioReserva.CustomFormat = "dd/MM/yyyy                            HH:mm";
            dtp_dataFimReserva.CustomFormat = "dd/MM/yyyy                            HH:mm";


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
                btn_criarReserva.Enabled = false;
            }
            else
            {
                btn_editarFuncionario.Enabled = true;
                btn_apagarFuncionario.Enabled = true;
                btn_criarReserva.Enabled = true;
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
                btn_criarReserva.Enabled = false;
            }
            else
            {
                btn_editarSala.Enabled = true;
                btn_apagarSala.Enabled = true;
                btn_criarReserva.Enabled = true;
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---Funcionario---

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


            if (sqlConnector.ListarReservasPorFuncionario(selecionado).Count != 0)
            {
                MessageBox.Show("O funcionário tem reservas a seu nome. Para o apagar, terá de apagar as reservas primeiro!", "Erro!");
            }
            else
            {
                sqlConnector.RemoverFuncionario(selecionado);
                WireUpLists();
            }
                
        }

        //---Salas---

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

            if (sqlConnector.ListarReservasPorSala(selecionado).Count != 0)
            {
                MessageBox.Show("A sala tem reservas marcadas. Para apagar a sala, terá de apagar as reservas primeiro!", "Erro!");
            }
            else
            {
                sqlConnector.RemoverSala(selecionado);
                WireUpLists();
            }
        }

        //-------Reservas------

        private void btn_criarReserva_Click(object sender, EventArgs e)
        {
            if (lb_sala.SelectedItem != null)
            {
                if (lb_funcionario.SelectedItem != null)
                {
                    if (dtp_dataInicioReserva.Value <= dtp_dataFimReserva.Value)
                    {

                        bool output = true;

                        FuncionarioModel funcSelecionado = (FuncionarioModel)lb_funcionario.SelectedItem;
                        SalaModel salaSelecionado = (SalaModel)lb_sala.SelectedItem;

                        ReservaModel model = new ReservaModel(funcSelecionado.IdFuncionario, salaSelecionado.IdSala, dtp_dataInicioReserva.Value,
                            dtp_dataFimReserva.Value);

                        //Verificar se a nova reserva está dentro (da data) de outra reserva já feita na sala linkada à reserva
                        List<ReservaModel> verificarReservas = sqlConnector.ListarReservasPorSala(salaSelecionado);
                        foreach (ReservaModel i in verificarReservas) 
                        {
                            if ((model.DataHoraInicio >= i.DataHoraInicio && model.DataHoraInicio < i.DataHoraFim) ||
                                (model.DataHoraFim > i.DataHoraInicio && model.DataHoraFim <= i.DataHoraFim) ||
                                (model.DataHoraInicio < i.DataHoraInicio && model.DataHoraFim > i.DataHoraFim))
                            {
                                

                                output = false;      
                            }
                        }
                        if (output == true)
                        {
                            sqlConnector.ReservarSala(model);

                            MessageBox.Show("Reserva criada com Sucesso!", "Sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Já existe uma reserva dentro da data especificada na sala selecionada", "Erro!");
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("A data do inicio da reserva não pode ser maior que a data do Final da reserva.", "Erro!");
                    }                 
                }
                else
                {
                    MessageBox.Show("Selecione um Funcionário da lista!", "Erro!");
                }

            }
            else
            {
                MessageBox.Show("Selecione uma sala da lista!", "Erro!");
            }

        }



    }
}
