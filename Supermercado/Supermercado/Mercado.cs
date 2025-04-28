using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{   
    public class Mercado
    {
        Dictionary<string, double> estoque = new Dictionary<string, double>();

        Dictionary<string, double> guardavalor = new Dictionary<string, double>();
        public void adicionarProduto(double presso,string produto)
        {
            if (estoque.ContainsKey(produto)){
                Console.WriteLine("Produto já adicionado");
            }
            else
            {
                estoque.Add(produto, presso);
            }
            
        } 
        public void removerProduto(string produto)
        {
            if (estoque.ContainsKey(produto))
            {
                estoque.Remove(produto);
                Console.WriteLine("Produto removido com sucesso");
                
            }
            else
            {
                Console.WriteLine("Produto inexistente");
            }
        }

       public string adiconarAoCarrinho(string produto)
        {
            if (estoque.ContainsKey(produto))
            {
                guardavalor = new Dictionary<string, double>(estoque);

                estoque.Remove(produto);
                Console.WriteLine("Produto removido com sucesso");
                return produto;
            }
            else
            {
                Console.WriteLine("Produto inexistente");
                return null;
            }
        }

        public string removerDoCarrinho(string produto)
        {
            if (!estoque.ContainsKey(produto))
            {
                estoque.Add(produto);
                Console.WriteLine("");
                return produto;
            }
            else
            {
                Console.WriteLine("Produto inexistente");
                return null;
            }
        }

    }
}
