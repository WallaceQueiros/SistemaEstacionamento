namespace SistemaEstacionamento.Models;

public class Estacionamento
{
    List<string> veiculos = new List<string>();
    public string CadastrarVeiculo(string placa)
    {
        veiculos.Add(placa);
        return placa;
    }

    public int RemoverVeiculo(int indice)
    {
        veiculos.RemoveAt(indice);
        return indice;
    }

    public string ListarVeiculos()
    {
        return string.Join(", ", veiculos);
    }
}