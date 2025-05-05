using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


public class Quadrado:FiguraGeometrica, Desenho
{
    int lado;
    public Quadrado(int lado)
    {
        this.lado = lado;
    }

    public override void CalcularPerimetro()
    {
        Console.WriteLine($"Perimetro do Quadrado{4*lado}");
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"Area do Quadrado{lado*lado}");
    }
    public void Desenhar()
    {
        int tamanho = (int)lado;
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if (i == 0 || i == tamanho - 1 || j == 0 || j == tamanho - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}

