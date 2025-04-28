using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicios2704;

public class Retangulo:FormaGeometrica
 {
    int Base;
    int altura;
    public Retangulo(int Base, int altura)
    {
     this.Base = Base;
     this.altura = altura;
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"Area do Retangulo: {Base * altura}");
    }
}

