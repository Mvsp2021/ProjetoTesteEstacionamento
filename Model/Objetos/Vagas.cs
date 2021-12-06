using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteSistemaEstacionamento.Model.Objetos
{
    public class Vagas
    {
        public int IdVaga { get; set; }

        public DateTime DataEntrada { get; set; }

        public string Placa { get; set; }

        public TimeSpan HoraEntrada { get; set; }

        public Vagas(DateTime dataEntrada, string placa, TimeSpan horaEntrada)
        {
            DataEntrada = dataEntrada;
            Placa = placa;
            HoraEntrada = horaEntrada;

        } 
    }
}
