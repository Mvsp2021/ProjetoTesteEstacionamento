using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Model
{
    public class DBConnection
    {
        /// <summary>
        /// Cadeia de conexão com o Banco de Dados Local
        /// </summary>
        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Martha\source\repos\ProjetoTesteSistemaEstacionamento\DataBase\DBEstaciona.mdf;Integrated Security=True");

        
    }
}
