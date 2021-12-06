using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Control.BAL
{
    class SaidaBal
    {
        /// <summary>
        /// Calcula o valor a pagar na saída do veículo do estacionamento
        /// </summary>
        /// <param name="horaSaida"></param>
        /// <param name="placa"></param>
        /// <returns></returns>
        public static double ValorPagar(TimeSpan horaSaida, string placa)
        {
            if (!string.IsNullOrEmpty(horaSaida.ToString()))
            {
                TimeSpan horaEntrada = Model.DAL.VagasDal.BuscaHoraEntrada(placa);

                TimeSpan diferenca = (horaSaida - horaEntrada);

                //Valor da hora base
                int valorBase = 2;

                //O valor da hora adicional possui uma tolerância de 10 minutos para cada 1 hora. Exemplo: 30 minutos valor R$ 1,00 | 1 hora valor R$ 2,00 | 1 hora 10 minutos valor R$ 2,00 | 1 hora e 15 minutos valor R$ 3,00 | 2 horas e 5 minutos valor R$ 3,00 | 2 horas e 15 minutos valor R$ 4,00.
                if (diferenca.TotalMinutes <= 30)
                {
                    return valorBase / 2;
                }
                else if (diferenca.TotalMinutes <= 70)
                {
                    return valorBase;
                }
                else if (diferenca.TotalMinutes <= 130)
                {
                    return valorBase + 1;

                }
                else if (diferenca.TotalMinutes <= 190)
                {
                    return valorBase + 2;
                }
                else if (diferenca.TotalMinutes <= 250)
                {
                    return valorBase + 3;
                }
                else if (diferenca.TotalMinutes <= 310)
                {
                    return valorBase + 4;
                }
                else if (diferenca.TotalMinutes <= 370)
                {
                    return valorBase + 5;
                }
                else if (diferenca.TotalMinutes <= 430)
                {
                    return valorBase + 6;
                }
                else if (diferenca.TotalMinutes <= 490)
                {
                    return valorBase + 7;
                }
                else if (diferenca.TotalMinutes <= 550)
                {
                    return valorBase + 8;
                }
                else if (diferenca.TotalMinutes <= 610)
                {
                    return valorBase + 9;
                }
            }
            return -3;
        }

        public static int LiberaVaga(string placa)
        {
            if (!string.IsNullOrEmpty(placa))
            {
                try
                {
                    Model.DAL.SaidaDal.LiberaVaga(placa);
                    return 0; // OK
                }
                catch (Exception)
                {

                    return -1; //Algo inesperado ocorreu
                }

            }
            return -2; //Erro algum campo está vazio
        }
    }
}
