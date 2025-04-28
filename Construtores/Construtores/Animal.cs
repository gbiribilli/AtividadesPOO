using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
     public class Animal
    {
        int qtdPatas;
        bool dormindo;
        string cor;
        public Animal(int qtdPatas,bool dormindo, string cor)
        {
            this.qtdPatas = qtdPatas;
            this.dormindo = dormindo;
            this.cor = cor;
        }
    }
}
