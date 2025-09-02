using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {

        double[] arrayValores = new double[2];
        private List<Carro> carrosRegistrados;
        

        public Estacionamento()
        {
            carrosRegistrados = new List<Carro>();
        }

        public void PausarTela()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void AtribuirValores()
        {
            bool exibirValorInicial = true;
            while (exibirValorInicial)
            {
                Console.WriteLine("Bem vindo ao Estacionamento. Digite o valor inicial:");

                string valorInicialTexto = Console.ReadLine();
                if (double.TryParse(valorInicialTexto, NumberStyles.Float, CultureInfo.InvariantCulture, out double resultadoValorInicial))
                {
                    double valorInicial = resultadoValorInicial;
                    arrayValores[0] = valorInicial;
                    exibirValorInicial = false;
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

            bool exibirValorAdicional = true;
            while (exibirValorAdicional)
            {
                Console.WriteLine("Digite o valor para as horas adicionais:");

                string valorAdicionalTexto = Console.ReadLine();
                if (double.TryParse(valorAdicionalTexto, NumberStyles.Float, CultureInfo.InvariantCulture, out double resultadoValorAdicional))
                {
                    double valorAdicional = resultadoValorAdicional;
                    arrayValores[1] = valorAdicional;
                    exibirValorAdicional = false;
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }

        }

        public bool ExisteRegistroEmAberto(string placa)
        {
            return carrosRegistrados.Any(carro => carro.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase)
                                                                    && carro.DataHoraSaida == null);
        }

        public bool CadastrarEntrada(out string mensagem)
        {
            Console.WriteLine("Digite a placa do veículo (ex: ABC-1D23):");

            string placaEntrada = Console.ReadLine();

            if (placaEntrada.Length != 8 || placaEntrada[3] != '-')
            {
                mensagem = "Formato de placa inválido! Use o formato: ABC-1234";
                return false;
            }

            if (ExisteRegistroEmAberto(placaEntrada))
            {
                mensagem = $"Não é possível cadastrar a placa {placaEntrada}. " +
                          "Já existe um registro em aberto para este veículo.";
                return false;
            }

            Console.WriteLine("Digite o horário de entrada:");

            string horarioEntrada = Console.ReadLine();

            if (DateTime.TryParseExact(horarioEntrada, "dd/MM/yyyy HH:mm",
                                  CultureInfo.InvariantCulture, DateTimeStyles.None,
                                  out DateTime resultado))
            {
                var novoCarro = new Carro(placaEntrada, horarioEntrada);
                carrosRegistrados.Add(novoCarro);
                mensagem = $"Veículo {placaEntrada} cadastrado com sucesso.";
                return true;
            }
            else
            {
                mensagem = "Hora de entrada inválida.";
                return false;
            }
        }

        public bool RegistrarSaida(out string mensagem)
        {
            Console.WriteLine("Digite a placa do veículo (ex: ABC-1D23):");

            string placaSaida = Console.ReadLine();

            var carroEmAberto = carrosRegistrados.FirstOrDefault(carro => carro.Placa.Equals(placaSaida, StringComparison.OrdinalIgnoreCase)
                                                                    && carro.DataHoraSaida == null);

            if (carroEmAberto == null)
            {
                mensagem = "Carro não encontrado.";
                return false;
            }
            else
            {
                Console.WriteLine("Digite o horário de saída:");

                string horarioSaida = Console.ReadLine();

                if (carroEmAberto != null)
                {
                    if (DateTime.TryParseExact(horarioSaida, "dd/MM/yyyy HH:mm",
                                          CultureInfo.InvariantCulture, DateTimeStyles.None,
                                          out DateTime resultado))
                    {
                        carroEmAberto.DataHoraSaida = resultado;

                        TimeSpan tempoEstacionado = resultado - carroEmAberto.DataHoraEntrada;

                        int horasCompletas = (int)tempoEstacionado.TotalHours;

                        double valorTotal = 0;
                        if (horasCompletas <= 1)
                        {
                            valorTotal = arrayValores[0];
                        }
                        else
                        {
                            valorTotal = arrayValores[0] + ((horasCompletas - 1) * arrayValores[1]);
                        }

                        mensagem =  $"Veículo {placaSaida} removido do estacionamento com sucesso.\n" +
                                    $"Tempo estacionado: {horasCompletas:F2} horas\n" +
                                    $"Valor a pagar: R$ {valorTotal:F2}";
                        return true;
                    }
                }
                mensagem = "Hora de saída inválida.";
                return false;
            }
        }

        public List<Carro> ObterCarroEmAberto()
        {
            return carrosRegistrados.Where(carro => carro.DataHoraSaida == null).ToList();
        }

        public List<Carro> ObterHistoricoPorPlaca(string placa)
        {
            return carrosRegistrados.Where(carro => carro.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}