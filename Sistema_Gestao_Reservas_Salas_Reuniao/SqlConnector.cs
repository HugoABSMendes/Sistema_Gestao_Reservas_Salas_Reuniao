using Dapper;
using Sistema_Gestao_Reservas_Salas_Reuniao.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestao_Reservas_Salas_Reuniao
{

    public class SqlConnector
    {
        private const string db = "ProjetoProgramacaoCET106";


        public string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void AdicionarFuncionario(FuncionarioModel model)
        {

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Nome", model.Nome);
                p.Add("@Email", model.Email);
                p.Add("@Departamento", model.Departamento);
                p.Add("@IdFuncionario", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAdicionarFuncionario", p, commandType: CommandType.StoredProcedure);

                model.IdFuncionario = p.Get<int>("@IdFuncionario");
            }

        }

        public void AdicionarSala(SalaModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Nome", model.Nome);
                p.Add("@Capacidade", model.Capacidade);
                p.Add("@Localizacao", model.Localizacao);
                p.Add("@IdSala", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAdicionarSala", p, commandType: CommandType.StoredProcedure);

                model.IdSala = p.Get<int>("@IdSala");
            }
        }

        public void ReservarSala(ReservaModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@IdFuncionario", model.IdFuncionario);
                p.Add("@IdSala", model.IdSala);
                p.Add("@DataHoraInicio", model.DataHoraInicio);
                p.Add("@DataHoraFim", model.DataHoraFim);
                p.Add("@IdReserva", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spReservarSala", p, commandType: CommandType.StoredProcedure);

                model.IdReserva = p.Get<int>("@IdReserva");
            }
        }

        public void AtualizarFuncionario(FuncionarioModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@IdFuncionario", model.IdFuncionario);
                p.Add("@Nome", model.Nome);
                p.Add("@Email", model.Email);
                p.Add("@Departamento", model.Departamento);

                connection.Execute("dbo.spAtualizarFuncionario", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void AtualizarSala(SalaModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@IdSala", model.IdSala);
                p.Add("@Nome", model.Nome);
                p.Add("@Capacidade", model.Capacidade);
                p.Add("@Localizacao", model.Localizacao);

                connection.Execute("dbo.spAtualizarSala", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void RemoverFuncionario(FuncionarioModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@IdFuncionario", model.IdFuncionario);

                connection.Execute("dbo.spRemoverFuncionario", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void RemoverSala(SalaModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@IdSala", model.IdSala);

                connection.Execute("dbo.spRemoverSala", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CancelarReserva(ReservaModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@IdReserva", model.IdReserva);

                connection.Execute("dbo.spCancelarReserva", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<FuncionarioModel> ListarFuncionarios()
        {
            List<FuncionarioModel> output;

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {

                output = connection.Query<FuncionarioModel>("dbo.spListarFuncionarios").ToList();

            }
            return output;
        }

        public List<SalaModel> ListarSalas()
        {
            List<SalaModel> output;

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {

                output = connection.Query<SalaModel>("dbo.spListarSalas").ToList();

            }
            return output;


        }

        public List<ReservaModel> ListarReservasPorFuncionario(FuncionarioModel model)
        {
            List<ReservaModel> output;

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@IdFuncionario", model.IdFuncionario);

                output = connection.Query<ReservaModel>("dbo.spListarReservasPorFuncionario", p, commandType: CommandType.StoredProcedure).ToList();

            }
            return output;


        }

        public List<ReservaModel> ListarReservasPorSala(SalaModel model)
        {
            List<ReservaModel> output;

            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@IdSala", model.IdSala);

                output = connection.Query<ReservaModel>("dbo.spListarReservasPorSala", p, commandType: CommandType.StoredProcedure).ToList();

            }
            return output;

        }


    }
}
