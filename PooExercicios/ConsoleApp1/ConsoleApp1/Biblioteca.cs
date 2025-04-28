using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();
        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }
        public void AlugarLivro(string titulo)
        {
            Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null)
            {
                livro.Alugar();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }

        }
        public void DevolverLivro(string titulo)
        {
            Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null)
            {
                livro.Devolver();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
        public void ListarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("A biblioteca está vazia.");
            }
            else
            {
                Console.WriteLine("Lista de livros na biblioteca:");
                foreach (var livro in livros)
                {
                    Console.WriteLine(livro);
                }
            }
        }
    }
}
