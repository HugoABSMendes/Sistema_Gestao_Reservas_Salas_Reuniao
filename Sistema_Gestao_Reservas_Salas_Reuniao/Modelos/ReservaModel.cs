using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestao_Reservas_Salas_Reuniao.Modelos
{
    public class ReservaModel
    {
        public int IdReserva { get; set; }

        public int IdFuncionario { get; set; }

        public int IdSala { get; set; }

        public DateTime DataHoraInicio { get; set; }

        public DateTime DataHoraFim { get; set; }

        public string DescricaoPorFuncionario
        {
            get
            {
                return $"Id Funcionário: {IdFuncionario}, Id Sala: {IdSala} | Início: {DataHoraInicio}, Fim: {DataHoraFim}";
            }
        }

        public string DescricaoPorSala
        {
            get
            {
                return $"Id Sala: {IdSala}, Id Funcionário: {IdFuncionario} | Início: {DataHoraInicio}, Fim: {DataHoraFim}";
            }
        }

        public ReservaModel(int idfuncionario, int idsala, DateTime datahorainicio, DateTime datahorafim)
        {


            IdFuncionario = idfuncionario;

            IdSala = idsala;

            DataHoraInicio = datahorainicio;

            DataHoraFim = datahorafim;
        }

        public ReservaModel(int idreserva ,int idfuncionario, int idsala, DateTime datahorainicio, DateTime datahorafim)
        {
            IdReserva = idreserva;

            IdFuncionario = idfuncionario;

            IdSala = idsala;

            DataHoraInicio = datahorainicio;

            DataHoraFim = datahorafim;
        }

    }
}
