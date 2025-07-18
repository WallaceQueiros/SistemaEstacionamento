﻿namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite uma placa: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de hora que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = (_precoInicial +  _precoPorHora) * horas;
                veiculos.Remove(placa);
                
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
  
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                foreach (string veiculosEstacionados in veiculos)
                {
                    Console.WriteLine($"Os veiculos estacionados são: {veiculosEstacionados}");
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados aqui.");
            }
        }
    }
}