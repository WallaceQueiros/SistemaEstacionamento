using SistemaEstacionamento.Models;

Estacionamento estacionamento = new Estacionamento();

string opcao = "";

while (true)
{
    Console.WriteLine("Bem-Vindo ao Sistema de Estacionamento!");
    Console.WriteLine();
    Console.WriteLine("Opções: ");
    Console.WriteLine(" 1 - Cadastrar Veículo\n 2 - Remover Veículo\n 3 - Listar Veículos\n 4 - Sair");
    Console.Write("Digite sua opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastre a placa do Veiculo: ");
            estacionamento.CadastrarVeiculo(Console.ReadLine());
            Console.WriteLine("Cadastro Realizado!");
            break;
        
        case "2":
            Console.WriteLine("Digite o Veículo que deseja remover: ");
            estacionamento.RemoverVeiculo(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Carro removido com sucesso!");
            break;
        
        case "3":
            Console.WriteLine("Veiculos Cadastrados: ");
            Console.WriteLine(estacionamento.ListarVeiculos());
            break;
        
        case "4":
            Console.WriteLine("Saindo do Sistema...");
            break;
    }
}