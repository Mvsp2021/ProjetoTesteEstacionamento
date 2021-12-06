using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Control.BAL
{
    class ErroBAL
    {
        /// <summary>
        /// Fornece as menssagens de erro para facilitar eventual manutenção
        /// </summary>
        /// <param name="resultado"></param>
        /// <returns></returns>
        public static string MensagemErro(int resultado)
        {
            if (resultado == -2)
            {
                string msg = "Algum campo está vazio";
                return msg;
            }
            else if (resultado == -3)
            {
                string msg = "Excedeu o horário da diária!!! Valor da Diária: R$";
                return msg;
            }
            else
            {
                string msg = "Algo inesperado ocorreu!!!";
                return msg;
            }

        }
    }
}
