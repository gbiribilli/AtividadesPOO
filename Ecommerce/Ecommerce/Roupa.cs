using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Roupa
    {   
      
        List<string> Armario = new List<string>();
        public Roupa()
        {
            Armario.Add("Camisa Star Wars - M - Preto");
            Armario.Add("Camisa Disney - P - Azul");
            Armario.Add("Camiseta DryFit - M - Preto");
        }

        public void adicionarRoupa(string tipo, string tamanho, string cor)
        {
            Armario.Add(tipo + "-" + tamanho + "-" + cor);
        }

        public void listarRoupas()
        {
            foreach (var item in Armario)
            {
                Console.WriteLine(item);
            }
        }
    }
}
