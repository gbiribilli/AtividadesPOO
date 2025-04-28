using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios2704
{
    public class Personagem
    {
        string nome;
        int vida = 100;
        string poder;
        public Personagem(string nome, string poder) {
            this.nome = nome;
            this.poder = poder;
        }

        public virtual void atacar(Personagem p)
        {
            Console.WriteLine($"{nome} atacou {p.nome} com {poder} ");
        }
       public  void perdaDeVida(Personagem p,int dano)
        {
            Console.WriteLine($"{p.nome} perdeu {dano} de vida");
            p.vida -= dano;
        }

        public void situacaoPersonagem()
        {
            Console.WriteLine($"{nome}:\nVida:{vida}\nPoder:{poder}");
                                    
        }
    }
}
