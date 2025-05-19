namespace Estudoprova;

public abstract class Paciente
{
    private string nome;
    private int idade;
    private string tipoProblema;
    public Paciente(string nome, int idade,string tipoProblema)
    {
        this.nome = nome;
        this.idade = idade;
        this.tipoProblema = tipoProblema;
    }
    public string Nome
    {
        get { return nome; }
    }
    public int Idade
    {
        get { return idade; }
    }
    public string TipoProblema{get{return tipoProblema;}}
}