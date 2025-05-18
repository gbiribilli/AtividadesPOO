namespace _99Taxi;

public class Pessoa
{   
    private string nome;
    private string cpf;
    private int estrelas;
    private bool estaEmCorrida;
    public Pessoa(string nome, string cpf, int estrelas, bool estaEmCorrida)
    {
       this.nome = nome;
       this.cpf = cpf;
       this.estrelas = estrelas;
       this.estaEmCorrida = estaEmCorrida;
    }
    
    public string Nome { get { return nome; } }
    public string CPF { get { return cpf; } }
    public int Estrelas { get { return estrelas; } }
    public bool EstaEmCorrida { get { return estaEmCorrida; } set { estaEmCorrida = value; } }
}