using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Model
{
    class DBFunction
    {
        /// <summary>
        /// Função para realizar o INSERT, DELETE ou UPDATE no Banco de Dados
        /// </summary>
        /// <param name="command"></param>
        public static void GenericExecute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, DBConnection.connection);
            DBConnection.connection.Open();
            cmd.ExecuteNonQuery();
            DBConnection.connection.Close();
        }

    }
}
