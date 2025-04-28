using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using exercicios2704;
public class Circulo :FormaGeometrica
{
    int raio;
    public Circulo(int raio) { 
        this.raio = raio;
    }
    public override void CalcularArea() { 
    
        Console.WriteLine($"Area do circulo: {3.14*(raio*raio)}");
    }

}

