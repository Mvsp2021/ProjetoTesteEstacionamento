using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Control.BAL
{
    class VagasBAL
    {
        public static List<string> MostraPlaca()
        {
            return Model.DAL.VagasDal.MostraPlaca();
        }

        public static int AdicionarVaga(string dataEntrada, string placa, string horaEntrada)
        {
            //Verifica se o usuário digitou nos campos corretamente
            if (!string.IsNullOrEmpty(dataEntrada) && !string.IsNullOrEmpty(placa) && !string.IsNullOrEmpty(horaEntrada) && placa.Length == 8 && horaEntrada.Length == 5)
            {
              
                    try
                    {
                        Model.DAL.VagasDal.InsereVaga(dataEntrada, placa, horaEntrada);
                        return 0; // OK
                    }
                    catch (Exception)
                    {

                        return -1; //Algo inesperado ocorreu
                    }
             
            }
            return -2; //Erro algum campo está vazio
        }

        public static List<Model.Objetos.Vagas> GetVagasPreenchidas()
        {
            return Model.DAL.VagasDal.GetVagasPreenchidas();
        }
    }
}
