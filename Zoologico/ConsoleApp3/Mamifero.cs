using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Mamifero:Animal, Visitavel
{
    string corPelagem, tipoAlimentacao;
    public Mamifero(string nome, int idade, string corPelagem,string tipoAlimentacao) : base(nome, idade)
    {
        this.corPelagem = corPelagem;
        this.tipoAlimentacao = tipoAlimentacao;
    }

    public override void EmitirSom()
    {
        Console.WriteLine("muuuuu");
    }
    public override void Movimentar()
    {
      Random r = new Random();
        int distancia = r.Next(1, 11);
        Console.WriteLine($"{nome} esta andando {distancia}metros!! UAU");
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}\nIdade:{idade}\nCor:{corPelagem}\nO que come:{tipoAlimentacao}");
    }
}

