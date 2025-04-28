using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Alimento
    {   
        List<string> alimentos = new List<string>();
        public Alimento() {
            alimentos.Add("Arroz - 2024 - Comida");
            alimentos.Add("Agua - 2028 - Liquido");
            alimentos.Add("Suco de Laranja - 2029 - Liquido");
        }
        
       public void AdicionarAlimento(string nome,int Validade, string Tipo )
        {
            alimentos.Add(nome + "-" + Validade + "-" + Tipo);
        }

        public void ListarAlimentos()
        {
            foreach (var a in alimentos)
            {
                Console.WriteLine(a);
            }
        }
    }
}
