using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Produto
    {

     

        public void ListarTodosProdutos(Livro l,Alimento a, Roupa r)
        {
            Console.WriteLine("Alimentos:");
            a.ListarAlimentos();
            Console.WriteLine("\n");

            Console.WriteLine("Livros:");
            l.ListarLivros();
            Console.WriteLine("\n");

            Console.WriteLine("Roupas:");
            r.listarRoupas();
        }
    }
}
