using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicios2704;

public class Triangulo :FormaGeometrica
  {
    int Base;
    int altura;
    public Triangulo(int Base, int altura) { 
        this.Base = Base;
        this.altura = altura;
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"Area do triangulo: {(Base*altura/2)}");
    }
  }

