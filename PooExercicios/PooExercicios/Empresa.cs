using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PooExercicios
{

    class Empresa
    {
        public string nome;
        public int cpf;
        public double salario;

        public double TotalBruto = 0;
        public double TotalLiquido = 0;
        public double TotalDescontado = 0;
        public void Info()
        {
            Console.WriteLine($"Nome do Funcionario: {nome}");
            Console.WriteLine($"CPF do Funcionario: {cpf}");
            Console.WriteLine($"Salario do Funcionario Bruto: {salario}");
            if (salario < 2000)
            {
                TotalBruto += salario;
                Console.WriteLine($"Salario do Funcionario Liquido: {salario}");
                TotalLiquido += salario;
            }

            if (salario >= 2000 && salario < 3000)
            {
                TotalBruto += salario;
                TotalDescontado += salario * (7.5 / 100);
                Console.WriteLine("Total descontado: {0}", salario * (7.5 / 100));
                salario = salario - (salario * (7.5 / 100));
                Console.WriteLine($"Salario do Funcionario Liquido: {salario}");
                TotalLiquido += salario;
            }

            if (salario >= 3000 && salario < 4000)
            {
                TotalBruto += salario;
                TotalDescontado += salario * (15 / 100);
                Console.WriteLine("Toal descontado: {0}", salario * (15 / 100));
                salario = salario - (salario * (15 / 100));
                Console.WriteLine($"Salario do Funcionario Liquido: {salario}");
                TotalLiquido += salario;
            }

            if (salario >= 4000 && salario < 5000)
            {
                TotalBruto += salario;
                TotalDescontado += salario * (22.5 / 100);
                Console.WriteLine("Total descontado: {0}", salario * (22.5 / 100));
                salario = salario - (salario * (22.5 / 100));
                Console.WriteLine($"Salario do Funcionario Liquido: {salario}");
                TotalLiquido += salario;
            }
            if (salario >= 5000)
            {
                TotalBruto += salario;
                TotalDescontado += salario * (27.5 / 100);
                Console.WriteLine("Total descontado: {0}", salario * (27.5 / 100));
                salario = salario - (salario * (27.5 / 100));
                Console.WriteLine($"Salario do Funcionario Liquido: {salario}");
                TotalLiquido += salario;
            }
            Console.WriteLine("\n");
        }
            
             
    }
    
}
