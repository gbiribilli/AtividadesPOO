using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ContaPoupanca : ContaBancaria,MovimentacaoConta
{
    string nome;
    double saldo;
    double taxaJuros = 0.05;
    public ContaPoupanca(string nome, double saldo)
    {
        this.nome = nome;
        this.saldo = saldo;
       
    }

    public void Depositar(double Valor)
    {
        Console.WriteLine($"Saldo Atual:R${saldo}");
        saldo += Valor;
        Console.WriteLine($"Saldo após deposito:R${saldo}");
    }
    public override void CalcularJuros(double valor, int dias)
    {
        double juros = valor * taxaJuros * dias;

        Console.WriteLine($"Com R${valor} e {dias} dias, você tera pago R${juros} em Juros");
    }
    public void Sacar(double Valor)
    {
        if (Valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para sacar, escolha um valor menor");
        }
        else
        {
            Console.WriteLine($"Saldo Atual:R${saldo}");
            saldo -= Valor;
            Console.WriteLine($"Saldo após deposito:R${saldo}");
        }

    }

}

