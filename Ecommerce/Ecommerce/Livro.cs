using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Livro
    {   
        List<string> lista = new List<string>();

        private string nome, marca, qtdPag, autor,titulo;
        private double valor;
        
        public Livro()
        {
            lista.Add("Diario de um Banana - Alguem - 500");
            lista.Add("Código Limpo - Roberto - 200");
            lista.Add("Jantar Secreto - Raphael - 150");
        }

        public void AdicionarLivro(string titulo, string autor, int qtdPag)
        {
            lista.Add(titulo +"-"+ autor+"-"+qtdPag);
        }

        public void ListarLivros()
        {
            foreach(var i in lista)
            {
                Console.WriteLine(i);
            }
        }
    }
}
