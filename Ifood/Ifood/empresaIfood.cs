using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifood
{
    public class empresaIfood
    {   Dictionary<string,double> Clientesdistancia = new Dictionary<string,double>();
        public Dictionary<string,string> Entregadores = new Dictionary<string,string>();
        string nomeCliente;
        double distancia;
        public void pedidos(string nomeCliente,double Distancia)
        {   
            Console.WriteLine($"{nomeCliente} possui um pedido, a {Distancia}KM");
            Clientesdistancia.Add(nomeCliente,Distancia);
            this.nomeCliente = nomeCliente;
            this.distancia = Distancia;

            localizar_entregador();
        }

        public void localizar_entregador()
        {
            if (Clientesdistancia.ContainsKey(nomeCliente))
            {     

                   if(distancia < 5 && Entregadores.ContainsKey("Bicicleta"))
                    {
                        Console.WriteLine($"-Localizamos um entregador Parceiro-\n{Entregadores["Bicicleta"]} está a caminho da unidade");
                        Console.WriteLine("Seu pedido saiu para entrega");
                    }
                    else if (distancia >= 5 && Entregadores.ContainsKey("Moto"))
                    {
                        Console.WriteLine($"-Localizamos um entregador Parceiro-\n{Entregadores["Moto"]} está a caminho da unidade");
                        Console.WriteLine("Seu pedido saiu para entrega");
                }
                    
                
            }
        }

       
    }
}
