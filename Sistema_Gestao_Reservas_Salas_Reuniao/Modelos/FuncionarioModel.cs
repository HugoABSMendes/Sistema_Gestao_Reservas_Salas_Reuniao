using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestao_Reservas_Salas_Reuniao.Modelos
{
    public class FuncionarioModel
    {
        public int IdFuncionario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Departamento { get; set; }

        public FuncionarioModel(string nome, string email, string departamento)
        {

            Nome = nome;

            Email = email;

            Departamento = departamento;
        }

        public FuncionarioModel(int idfuncionario, string nome, string email, string departamento)
        {
            IdFuncionario = idfuncionario;

            Nome = nome;

            Email = email;

            Departamento = departamento;
        }

    }

    


}
