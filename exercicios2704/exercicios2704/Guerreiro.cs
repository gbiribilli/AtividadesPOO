using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios2704 { 
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, string poder) : base(nome,poder)
        {

        }
        int dano = 10;
        Random random = new Random();
        public override void atacar(Personagem p){
            base.atacar(p);

        int n = random.Next(1, 101);
                if (n >= 1 && n <= 30)
                {
                    Console.WriteLine($"Causando {dano * 2}");
                    p.perdaDeVida(p, dano* 2);
                }
                else
                {
                    Console.WriteLine($"Causando {dano}");
                    p.perdaDeVida(p, dano);
                }
          }
    }
}
