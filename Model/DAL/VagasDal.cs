using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Model.DAL
{
    class VagasDal
    {
        /// <summary>
        /// Realiza a busca do horário de entrada da placa indicada para calcular o valor a pagar na saída
        /// </summary>
        /// <param name="placa"></param>
        /// <returns></returns>
        public static TimeSpan BuscaHoraEntrada(string placa)
        {
            TimeSpan hora = new TimeSpan();
            string select = $"SELECT HoraEntrada FROM dbo.Vagas WHERE Placa = '{placa}'";
            SqlCommand cmd = new SqlCommand(select, DBConnection.connection);
            if (DBConnection.connection.State == System.Data.ConnectionState.Closed)
            {
                DBConnection.connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hora = dr.GetTimeSpan(0);
                
            }
            dr.Close();
            DBConnection.connection.Close();
            return hora;
        }

        /// <summary>
        /// INSERT na tabela os dados de um veículo que estacionou
        /// </summary>
        /// <param name="data"></param>
        /// <param name="placa"></param>
        /// <param name="horaEntrada"></param>
        public static void InsereVaga(string dataEntrada, string placa, string horaEntrada)
        {
            string insert = $"INSERT into dbo.Vagas (DataEntrada, Placa, HoraEntrada) VALUES ('{dataEntrada}', '{placa}', '{horaEntrada}')";
            DBFunction.GenericExecute(insert);
        }


        /// <summary>
        /// Realiza um SELECT na tabela para mostrar as placas dos veiculos que estão estacionados
        /// </summary>
        /// <returns></returns>
        public static List<string> MostraPlaca()
        {
            List<string> lista = new List<string>();
            string select = $"SELECT * FROM dbo.Vagas WHERE Placa = placa";
            SqlCommand cmd = new SqlCommand(select, DBConnection.connection);
            if (DBConnection.connection.State == System.Data.ConnectionState.Closed)
            {
                DBConnection.connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string placa =  dr["Placa"].ToString();
                lista.Add(placa);
            }
            dr.Close();
            DBConnection.connection.Close();
            return lista;
        }

        /// <summary>
        /// Realiza um SELECT na tabela para mostrar as vagas do estacionamento que estão preenchidas no momento
        /// </summary>
        /// <returns></returns>
        public static List<Objetos.Vagas> GetVagasPreenchidas()
        {
            List<Objetos.Vagas> lista = new List<Objetos.Vagas>();
            string select = $"SELECT * FROM dbo.Vagas";
            SqlCommand cmd = new SqlCommand(select, DBConnection.connection);
            if (DBConnection.connection.State == System.Data.ConnectionState.Closed)
            {
                DBConnection.connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Objetos.Vagas usuarios = new Objetos.Vagas(dr.GetDateTime(1), dr["Placa"].ToString(), dr.GetTimeSpan(3));
                lista.Add(usuarios);
            }
            dr.Close();
            DBConnection.connection.Close();
            return lista;
        }
    }
}
