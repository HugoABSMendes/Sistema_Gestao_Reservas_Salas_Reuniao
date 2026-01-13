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

        private string DataHoraInicioFormat
        {
            get
            {
                return $"{DataHoraInicio.Day}/{DataHoraInicio.Month}/{DataHoraInicio.Year}  {DataHoraInicio.Hour}:{DataHoraInicio.Minute}";
            }
        }
        private string DataHoraFimFormat
        {
            get
            {
                return $"{DataHoraFim.Day}/{DataHoraFim.Month}/{DataHoraFim.Year}  {DataHoraFim.Hour}:{DataHoraFim.Minute}";
            }
        }

        public string DescricaoPorFuncionario
        {
            get
            {
                return $"Id Funcionário: {IdFuncionario}, Id Sala: {IdSala} | Início: {DataHoraInicioFormat} | Fim: {DataHoraFimFormat}";
            }
        }

        public string DescricaoPorSala
        {
            get
            {
                return $"Id Sala: {IdSala}, Id Funcionário: {IdFuncionario} | Início: {DataHoraInicioFormat} | Fim: {DataHoraFimFormat}";
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
