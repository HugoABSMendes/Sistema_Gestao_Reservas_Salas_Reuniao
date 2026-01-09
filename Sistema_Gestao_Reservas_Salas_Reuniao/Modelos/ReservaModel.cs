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



        public ReservaModel(int idfuncionario, int idsala, DateTime datahorainicio, DateTime datahorafim)
        {


            IdFuncionario = idfuncionario;

            IdSala = idsala;

            DataHoraInicio = datahorainicio;

            DataHoraFim = datahorafim;
        }

    }
}
