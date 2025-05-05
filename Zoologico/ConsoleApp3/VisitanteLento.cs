using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VisitanteLento:Visitante
{
    string nome = "Biribilli";
    public override void Visitar(Zoologico z)
    {
        for(int i = 0; i < z.Animaiss.Count; i++)
        {
            Console.WriteLine($"{nome} esta observando {z.Animaiss[i].Nome} ");
            z.Animaiss[i].EmitirSom();
            z.Animaiss[i].Movimentar();
            Console.WriteLine();
        }
    }
}

