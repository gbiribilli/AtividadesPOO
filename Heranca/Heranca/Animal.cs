using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Animal
    {
        protected string nome;
        protected string cor;
        protected string especie;
        protected string som;
        protected string Domestico;
        protected string selvagem;
        public Animal(string nome,string cor,string especie,string som, string domestico)
        {
            this.nome = nome;
            this.cor = cor; 
            this.especie = especie; 
            this.som = som;
            this.Domestico = domestico;
            this.selvagem = selvagem;
        }
        
        public void andar()
        {
            Console.WriteLine($"{nome}Andou 100metros");
        }

        public void mostrarCaracteriscas()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Especie: {especie}");
            Console.WriteLine($"som: {som}");
            Console.WriteLine($"Mora em: {Domestico}");

        }
    }
}
