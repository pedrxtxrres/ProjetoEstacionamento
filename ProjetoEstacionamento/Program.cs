using ProjetoEstacionamento.Models;

// Adicionar Veiculo
// Remover Veiculo
// Listas quais veículos tem
// Quando remover veiculo passar o valor para o cliente

string opcao;
bool exibirMenu = true;
Estacionamento estacionamento = new Estacionamento();


estacionamento.AtribuirValores();


while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("=== MENU PRINCIPAL ===");
    Console.WriteLine("Bem vindo ao Estacionamento. Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Listas veículos");
    Console.WriteLine("3 - Remover veículo");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            estacionamento.AdicionarVeiculo();

            break;
        case "2":

            estacionamento.ListarVeiculos();

            break;
        case "3":

            estacionamento.RemoverVeiculo();

            break;
        case "4":
            Console.WriteLine("Sair");
            exibirMenu = false;
            //Environment.Exit(0);
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
    }
}
    Console.WriteLine("O programa se encerrou");
    