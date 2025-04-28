using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class gato : Animal
    {
        string nome, cor, especie, som,domestico;
        public gato(string nome, string cor,string especie,string som, string Domestico ) :base(nome,cor,especie,som,Domestico) { 
            this.nome = nome;
            this.cor = cor;   
            this.especie = especie;
            this.som = som;
            this.domestico = Domestico;
        }
       public void miar()
        {
            som = "Miau";
            Console.WriteLine($"{nome} miau miau");
        }

        public void dormir()
        {
            Console.WriteLine($"{nome} está dormindo xiiiu");
        }
        public void acordar()
        {
            Console.WriteLine($"BANG {nome} agora está acordado");
        }
    }
}
