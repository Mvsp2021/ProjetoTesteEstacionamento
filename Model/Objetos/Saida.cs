using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Model.Objetos
{
    class Saida
    {
        public int IdSaida { get; set; }

        public DateTime DataSaida { get; set; }

        public string Placa { get; set; }

        public TimeSpan HoraSaida { get; set; }

        public Saida(DateTime dataSaida, string placa, TimeSpan horaSaida)
        {
            DataSaida = dataSaida;
            Placa = placa;
            HoraSaida = horaSaida;

        }
    }
}
