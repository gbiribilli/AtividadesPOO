using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood
{
    public class Cliente
    {
        public string nome;
        public double distanciaLocal;
        public Cliente(string nome, double ondemora) { 
            this.nome = nome;
            this.distanciaLocal = ondemora;
        }    

       
    }
}
