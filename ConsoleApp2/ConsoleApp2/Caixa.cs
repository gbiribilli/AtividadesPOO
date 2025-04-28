using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Caixa
    {
        string login;
        string senha;
        private double saldo;
        Dictionary<string, double> extrato = new Dictionary<string, double>();
        public Caixa(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
            Console.WriteLine("Conta criada com sucesso");
        }
         
        public void deposito(double qtdDinheiro)
        {
            this.saldo += qtdDinheiro;
            Console.WriteLine($"Atualmente você possui: {this.saldo}");
            extrato.Add("Adicinou:", qtdDinheiro);
        }

        public void sacar(double sacar)
        {
          if(sacar > this.saldo)
            {
                Console.WriteLine("Saldo insuficiente");
          }

            else if(this.saldo == 0) {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                this.saldo -= sacar;
                extrato.Add("Foi removido:", sacar);
            }
        }
        public void verConta()
        {
            Console.WriteLine($"Você possui: {this.saldo}");
        }
        public void extratoConta()
        {
            Console.WriteLine("Extrato:");
            foreach(var n in extrato)
            {
                Console.WriteLine($"{n.Key}: {n.Value}");
            }
        }

    }
}
