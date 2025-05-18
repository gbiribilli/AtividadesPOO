namespace _99Taxi;

public class Motorista:Pessoa
{
    public Motorista(string nome, string cpf,int estrelas,bool estaEmCorrida) :base(nome, cpf,estrelas,estaEmCorrida)
    {
        
    }
    
    public int ChamadaCorrida(Corrida corrida)
    {
        Console.WriteLine($"{Nome}, foi encontrado uma corrida para você");
        Console.WriteLine($"--INFORMAÇÕES DO PASSAGEIRO--\nNome:{corrida.Passageiro.Nome}\nLocal de Saida:" +
                          $"{corrida.EnderecoOrigem}\nLocal de chegada:{corrida.EnderecoDestino}\nQuantidade de Estrelas:" +
                          $"{corrida.Passageiro.Estrelas}");
        Console.WriteLine("Aceitar corrida ?");
        int escolha = Convert.ToInt32(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Corrida Aceita!");
                EstaEmCorrida = true;
                return 1;
                break;
            case 2:
                Console.WriteLine("Corrida recusada");
                break;
        }
        return 0;
    }
}