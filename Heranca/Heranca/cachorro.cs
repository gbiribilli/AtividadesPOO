using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class cachorro:Animal
    {
        int cansaço= 100;
        string DomesticoOuSelvagem;
        public cachorro(string nome, string cor, string especie, string som,string Domestico) :base( nome, cor,especie,som, Domestico)
        {
            this.DomesticoOuSelvagem = DomesticoOuSelvagem;
        }

        public void andar()
        {
            Console.WriteLine($"{nome} está andando");
            cansaço -= 50;
            if (cansaço == 0)
            {
                Console.WriteLine($"{nome} Não consegue andar mais");
            }
        }
        public void descanso()
        {
            Console.WriteLine($"{nome} Descançou");
            cansaço = 100;
        }

       
        
    }
}
