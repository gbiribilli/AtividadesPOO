namespace _99Taxi;

public class Corrida
{
    private string enderecoDestino;
    private string enderecoOrigem;
    private Pessoa passageiro;
    private DateTime dataDaCorrida;
    public Corrida(Pessoa passageiro,string enderecoDestino, string enderecoOrigem,DateTime dataDaCorrida)
    {
        this.passageiro = passageiro;
        this.enderecoDestino = enderecoDestino;
        this.enderecoOrigem = enderecoOrigem;
        this.dataDaCorrida = dataDaCorrida;
        procurarMotorista();
    }
    public string EnderecoDestino { get { return enderecoDestino; } }
    public string EnderecoOrigem { get { return enderecoOrigem; } }
    public Pessoa Passageiro { get { return passageiro; } }
    public DateTime DataDaCorrida { get { return dataDaCorrida; } }
    public void procurarMotorista()
    {
        Console.WriteLine("Procurando Motorista");
        
    }
}