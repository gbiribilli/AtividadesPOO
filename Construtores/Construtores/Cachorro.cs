using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class Cachorro : Animal
    {
        public Cachorro(int qtdPatas, bool dormindo, string cor) : base(qtdPatas, dormindo, cor)
        {
        }
        public void latir()
        {
            Console.WriteLine("Auau");
        }
    }
}
