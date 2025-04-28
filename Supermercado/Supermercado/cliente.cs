using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
   public class cliente
    {
        List<string> carrinho = new List<string>();

        public void adcionarCarrinho(string produto,Mercado mercado)
        {
            carrinho.Add(mercado.adiconarAoCarrinho(produto));
        }
        public void removerCarrinho(string produto)
        {
            carrinho.Remove(Mercado.removerDoCarrinho());
        }
    }
}
