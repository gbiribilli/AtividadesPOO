using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios2704
{
    public class Arqueiro :Personagem
    {
        int qtdFlechas;
        public Arqueiro(string nome, string poder,int qtdFlechas) : base(nome,poder) {
            this.qtdFlechas = qtdFlechas;
        }

        public override void atacar(Personagem p)
        {
            int dano = 10;
            Random random = new Random();
            base.atacar(p);
            int n = random.Next(1, 101);
          if(qtdFlechas > 0)
            {
             Console.WriteLine($"Causando {dano}");
             p.perdaDeVida(p, dano);
             qtdFlechas--;
           }         
        }
    }
}
