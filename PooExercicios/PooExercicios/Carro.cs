using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExercicios
{
  
    class Carro
    {
        Random numero = new Random();
        public string cor = "Vermehlo";
        public string modelo = Console.ReadLine();
        public string placa = "123E25";

        int velocidade = 0;
        public void Acelerar()
        {
            int numeroR = numero.Next(1, 31);
            velocidade += numeroR;
            Console.WriteLine($"{modelo} Acelerou em {numeroR}");
            Console.WriteLine($"Velocidade do Carro: {velocidade}");

            if(velocidade > 80)
            {   

                int multa = (velocidade - 80) * 5;
                Console.WriteLine($"Multa de : {multa}");
                Console.WriteLine("\n");
            }
            }
        public void frear(int frenagem)
        {
            int numeroR = numero.Next(1, 31);
            velocidade -= numeroR;
            Console.WriteLine($"{modelo}Velocidade do Carro : {velocidade}");
        }

    }
    
        

}
