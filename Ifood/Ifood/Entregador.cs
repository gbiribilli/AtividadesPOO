using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood
{
    public class Entregador
    {
        public string nome;
        public string veiculo;
        public Entregador(string nome, string veiculo,empresaIfood e) {
            this.nome = nome;
            this.veiculo = veiculo;
            e.Entregadores.Add(veiculo, nome);
        }

          
    }
}
