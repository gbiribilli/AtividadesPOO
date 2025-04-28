using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Retangulo
    {
        private int altura;
        private int largura;
        public Retangulo(int altura, int largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public void area()
        {
            Console.WriteLine($"Area do Retangulo:{altura*largura}");
        }
        public void perimetro()
        {
            Console.WriteLine($"Perimetro do Retangulo:{(this.altura*2) + (this.largura*2)}");
        }
    }
}
