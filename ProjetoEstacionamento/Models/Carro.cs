using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace ProjetoEstacionamento.Models
{
    public class Carro
    {
        public string Placa { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime? DataHoraSaida { get; set; }

        public Carro(string placa, string dataHoraEntrada)
        {
            Placa = placa;
            if (DateTime.TryParseExact(dataHoraEntrada, "dd/MM/yyyy HH:mm",
                                  CultureInfo.InvariantCulture, DateTimeStyles.None,
                                  out DateTime resultado)) 
            {
                DataHoraEntrada = resultado;
            }
            else
            {
                throw new ArgumentException("Hora de entrada inválida.");
            }
            DataHoraSaida = null;
        }
    }
}
