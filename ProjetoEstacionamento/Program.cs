using ProjetoEstacionamento.Models;

string opcao;
bool exibirMenu = true;
Estacionamento estacionamento = new Estacionamento();

Console.Clear();
estacionamento.AtribuirValores();


while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("=== MENU PRINCIPAL ===");
    Console.WriteLine("Bem vindo ao Estacionamento. Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar entrada de veículo");
    Console.WriteLine("2 - Listas veículos em aberto");
    Console.WriteLine("3 - Listas histórico por placa");
    Console.WriteLine("4 - Cadastrar saída de veículo");
    Console.WriteLine("5 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();

            string mensagemEntrada;

            estacionamento.CadastrarEntrada(out mensagemEntrada);

            Console.WriteLine($"\n{mensagemEntrada}");

            estacionamento.PausarTela();

            break;
        case "2":
            List<Carro> carrosEmAberto = estacionamento.ObterCarroEmAberto();

            if (carrosEmAberto.Count > 0)
            {
                Console.WriteLine("Carros em aberto:");
                foreach (Carro carro in carrosEmAberto)
                {
                    Console.WriteLine($"Placa: {carro.Placa} - Entrada: {carro.DataHoraEntrada}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum carro em aberto no momento.");
            }

            estacionamento.PausarTela();

            break;
        case "3":
            Console.WriteLine("Digite a placa do veículo:");

            string placaHistorico = Console.ReadLine();

            List<Carro> historico = estacionamento.ObterHistoricoPorPlaca(placaHistorico);

            if (historico.Count > 0)
            {
                Console.WriteLine($"Histórico da placa {placaHistorico}:");
                foreach (Carro carro in historico)
                {
                    string saida = carro.DataHoraSaida?.ToString("dd/MM/yyyy HH:mm") ?? "Em aberto";
                    Console.WriteLine($"Entrada: {carro.DataHoraEntrada:dd/MM/yyyy HH:mm} - Saída: {saida}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhum registro encontrado para a placa {placaHistorico}.");
            }

            estacionamento.PausarTela();

            break;
        case "4":
            Console.Clear();

            string mensagemSaida;

            estacionamento.RegistrarSaida(out mensagemSaida);

            Console.WriteLine($"\n{mensagemSaida}");

            estacionamento.PausarTela();

            break;
        case "5":
            Console.WriteLine("Sair");
            exibirMenu = false;
            //Environment.Exit(0);
            estacionamento.PausarTela();

            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
    }
}
    Console.WriteLine("O programa se encerrou");

