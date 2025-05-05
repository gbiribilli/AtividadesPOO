using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangulo:FiguraGeometrica,Desenho
{   
  
    int lado1, lado2, lado3;
    public Triangulo(int lado1, int lado2, int lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public override void CalcularArea()
    {
        double s = (lado1 + lado2 + lado3) / 2;
        double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        Console.WriteLine($"Area do Triangulo: {area}");
    }
    public override void CalcularPerimetro()
    {
        Console.WriteLine($"Perimetro do Triangulo:{lado1 + lado2 + lado3}");
    }
    public void Desenhar()
    {
        int altura = (int)Math.Min(Math.Min(lado1, lado2), lado3);
        for (int i = 1; i <= altura; i++)
        {
            // Espaços em branco para centralizar o triângulo
            for (int j = 1; j <= altura - i; j++)
            {
                Console.Write(" ");
            }

            // Asteriscos para formar o triângulo
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                if (k == 1 || k == 2 * i - 1 || i == altura)
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

