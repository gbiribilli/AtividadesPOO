using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Reptil:Animal,Visitavel
{
    double comprimento;
    string habitat;
    public Reptil(string nome, int idade,double comprimento, string habitat):base(nome,idade)
    {
        this.comprimento = comprimento;
        this.habitat = habitat;
    }

    public override void EmitirSom()
    {
        Console.WriteLine("rruuaaaaaa");
    }
    public override void Movimentar()
    {
        Random r = new Random();
        int distancia = r.Next(1, 11);
        Console.WriteLine($"{nome} esta andando {distancia}metros!! UAU");
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}\nIdade:{idade}\nComprimento:{comprimento}\nhabitat:{habitat}");
    }
}

