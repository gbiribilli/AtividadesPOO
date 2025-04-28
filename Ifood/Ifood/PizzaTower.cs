using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood
{
    
    public class PizzaTower:empresaIfood
    {       
        List<string> cardapio = new List<string>();
        
      public PizzaTower() {
            cardapio.Add("Calabresa");
            cardapio.Add("Mussarela");
            cardapio.Add("Pepperoni");
            cardapio.Add("Marguerita");
        }
      
        public void pedirPizza(Cliente c, string sabor, empresaIfood e)
        {
            if (!cardapio.Contains(sabor)) {
                Console.WriteLine("Não temos pizza desse sabor!\nPor favor escolha outro sabor");
            }
            else
            {
                Console.WriteLine($"Uma Pizza de {sabor} saindo ja!");
                e.pedidos(c.nome, c.distanciaLocal);
                
            }
        }
            
    }
}
