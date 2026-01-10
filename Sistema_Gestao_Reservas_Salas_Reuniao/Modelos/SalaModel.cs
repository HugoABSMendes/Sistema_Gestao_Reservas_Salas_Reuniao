using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestao_Reservas_Salas_Reuniao.Modelos
{
    public class SalaModel
    {
        public int IdSala { get; set; }

        public string Nome { get; set; }

        public int Capacidade { get; set; }

        public string Localizacao { get; set; }



        public SalaModel(string nome, int capacidade, string localizacao)
        {


            Nome = nome;

            Capacidade = capacidade;

            Localizacao = localizacao;


        }

        public SalaModel(int idsala, string nome, int capacidade, string localizacao)
        {
            IdSala = idsala;

            Nome = nome;

            Capacidade = capacidade;

            Localizacao = localizacao;


        }
    }
}
