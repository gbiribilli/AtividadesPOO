using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoPublicacao { get; private set; }
        public bool EstaAlugado { get; private set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            EstaAlugado = false;
        }

        public void Alugar()
        {
            if (!EstaAlugado)
            {
                EstaAlugado = true;
                Console.WriteLine($"Livro '{Titulo}' alugado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Livro '{Titulo}' já está alugado.");
            }
        }

        public void Devolver()
        {
            if (EstaAlugado)
            {
                EstaAlugado = false;
                Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Livro '{Titulo}' não está alugado.");
            }
        }


    }
}
