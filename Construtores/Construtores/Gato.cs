using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Gato : Animal
    {
        public Gato(int qtdPatas, bool dormindo, string cor) : base(qtdPatas, dormindo, cor)
        {
        }
        public void miar()
        {
            Console.WriteLine("Miau");
        }
    }
}
