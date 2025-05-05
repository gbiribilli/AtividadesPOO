using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circulo:FiguraGeometrica, Desenho
{
    int raio;
    public Circulo(int raio)
    {
        this.raio = raio;
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"Area do Circulo:{3.14*(raio*raio)}");
    }
    public override void CalcularPerimetro()
    {
        Console.WriteLine($"Perimetro do Circulo:{2*3.14*raio}");
    }
    public void Desenhar()
    {
         int diametro = (int)(2 * raio);
            for (int i = 0; i <= diametro; i++)
            {
                for (int j = 0; j <= diametro; j++)
                {
                    double distancia = Math.Sqrt(Math.Pow(i - raio, 2) + Math.Pow(j - raio, 2));
                    if (Math.Abs(distancia - raio) < 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        
    }
}

