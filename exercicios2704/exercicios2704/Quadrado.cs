using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicios2704;

public class Quadrado:FormaGeometrica
{
    int lado;
    public Quadrado(int lado)
    {
        this.lado = lado;
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"Area do quadrado: {lado*lado}");
    }
}

