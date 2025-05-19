namespace Estudoprova;

public class Emergencia:Paciente,InformacoesAdicionais
{
    private bool estadoGrave = false;
    public Emergencia(string nome, int idade, string tipoProblema,bool estadoGrave) : base(nome, idade, tipoProblema)
    {
        this.estadoGrave = estadoGrave;
    }

    public string InformacoesAdicionais()
    {
        if (estadoGrave)
        {
            return "Estado Grave";
        }
        else
        {
            return "Estado Não Grave";
        }
    }
    public bool EstadoGrave{get{return estadoGrave;}}
}