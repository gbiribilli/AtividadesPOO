using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ContaInvestimento:ContaBancaria,MovimentacaoConta
{
    string nome;
    double saldo;
    double rendimentoAnual;
    public ContaInvestimento(string nome, double saldo)
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
        Console.WriteLine("Não há Juros a serem calculados");
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
    public void investir(double Valor)
    {
        if (Valor > saldo)
        {
            Console.WriteLine($"Você precisa de mais {Valor - saldo} para realizar sua aplicação ");
        }
        else
        {
            saldo -= Valor;
            Console.WriteLine("investimento realizado com sucesso");
        }
    }
    public void verificarInvestimento()
    {
        Random r = new Random();
        int n = r.Next(1, 5);
        if(n == 1)
        {
            Console.WriteLine("Ações subindo!");
            rendimentoAnual += 200;
        }
        else
        {
            Console.WriteLine("Ações caindo!");
            rendimentoAnual -= 100000;
        }
    }
    public void retirarInvestimento()
    {
        saldo += rendimentoAnual;
        Console.WriteLine($"Saldo atual {saldo}");
    }
}

