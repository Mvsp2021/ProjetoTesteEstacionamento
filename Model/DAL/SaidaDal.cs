using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Model.DAL
{
    class SaidaDal
    {
        /// <summary>
        /// Realiza um DELETE na tabela quando um veículo libera uma vaga no estacionamento
        /// </summary>
        /// <param name="placa"></param>
        public static void LiberaVaga(string placa)
        {
            string delete = $"DELETE from dbo.Vagas WHERE Placa = '{placa}'";
            DBFunction.GenericExecute(delete);
        }

    }
}
