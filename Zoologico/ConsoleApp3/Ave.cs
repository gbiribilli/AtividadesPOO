using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ave:Animal, Visitavel
{
    string corPenas, tipoVoo;
    public Ave(string nome, int idade,string corPenas, string tipoVoo):base(nome,idade)
    {
        this.corPenas = corPenas;
        this.tipoVoo = tipoVoo;
    }

    public override void Movimentar()
    {
        Random r = new Random();
        int distancia = r.Next(1, 11);
        Console.WriteLine($"{nome} esta andando {distancia}metros!! UAU");
    }
    public override void EmitirSom()
    {
        Console.WriteLine("aaahhh");
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}\nIdade:{idade}\nColoração:{corPenas}\nTipo de Voo:{tipoVoo}");
    }
}


