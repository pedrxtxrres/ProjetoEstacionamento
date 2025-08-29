using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        string placa;
        int horasPermanecidas;
        int valorInicial;
        int valorVariavel;
        int[] arrayValores = new int[2];
        List<string> listaVeiculos = new List<string>();

        public void PausarTela()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void AtribuirValores()
        {
            Console.WriteLine("Bem vindo ao Estacionamento. Digite o valor inicial:");

            valorInicial = Convert.ToInt32(Console.ReadLine());

            arrayValores[0] = valorInicial;

            Console.WriteLine("Digite o valor para as horas adicionais:");

            valorVariavel = Convert.ToInt32(Console.ReadLine());

            arrayValores[1] = valorVariavel;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();

            Console.WriteLine("Digite a placa do veículo:");

            placa = Console.ReadLine();

            listaVeiculos.Add(placa);

            Console.WriteLine("\nVeículo adicionado com sucesso!");

            PausarTela();
        }

        public void ListarVeiculos()
        {
            Console.Clear();

            foreach (string veiculo in listaVeiculos)
            {
                Console.WriteLine(veiculo);
            }

            PausarTela();
        }

        public void RemoverVeiculo()
        {
            Console.Clear();

            Console.WriteLine("Qual veículo deseja remover?");

            placa = Console.ReadLine();

            listaVeiculos.Remove(placa);

            Console.WriteLine("Quantas horas o veículo permaneceu no estacionamento?");

            horasPermanecidas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O valor total do veículo {placa} foi de: R${arrayValores[0] + (arrayValores[1] * horasPermanecidas)}");

            PausarTela();
        }
    }
}