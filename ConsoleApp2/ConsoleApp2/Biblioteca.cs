using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   /* public class Biblioteca
    {
        private string nomeLivro;
        private string autor;
        private int data;
        string user { get; set; }

        Dictionary<string, int> livros = new Dictionary<string, int>();
                
        public void adicionarLivro(string nomeLivro,string autor,int data, int qtd)
        {
            if (livros.ContainsKey(nomeLivro))
            {
                livros[nomeLivro] += qtd;
            }
            else
            {
                livros.Add(nomeLivro, qtd);
            }   
        }
               
        public void alugar(string nome)
        {
            if (livros.ContainsKey(nome))
            {
                livros[nome]--;
                Console.WriteLine($"Livro alugado com sucesso");
            }
        }
        public void consultarLivros()
        {
            Console.WriteLine("Livros disponiveis: ");
            foreach(var n in livros)
            {
                Console.WriteLine($"{livros.Keys}:{livros.Values}");
            }
        }
        public void removerLivro(string nome)
        {
            if (livros.ContainsKey(nome))
            {
                livros.Remove(nome);
                Console.WriteLine("Removido");
            }
        }
    }*/
}
