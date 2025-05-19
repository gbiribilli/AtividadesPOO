namespace Estudoprova;

public class Internado:Paciente,InformacoesAdicionais
{
    private int quartoHospedado;
    public Internado(string nome, int idade, string tipoProblema, int quartoHospedado) : base(nome, idade,tipoProblema)
    {
       this.quartoHospedado = quartoHospedado;
    }
    
   
    public int QuartoHospedado{get{return quartoHospedado;}}

    public string InformacoesAdicionais()
    {
        return $"{Convert.ToString(quartoHospedado)}";

    }
}