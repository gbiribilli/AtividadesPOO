using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ContaCorrente : ContaBancaria,MovimentacaoConta
{
    string nome;
    double saldo;
    double TaxaManutencao = 200;
    public ContaCorrente(string nome, double saldo)
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
        Console.WriteLine("Não há Juros");
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

    public void Manutencao()
    {
        Console.WriteLine("OS NEGÓCIOS ESTÃO FLUINDO,PORÉM VOCE PRECISA PAGAR O AR CONDICIONADO");
        saldo -= TaxaManutencao;
        Console.WriteLine($"SEU NOVO SALDO É DE {saldo},VOCÊ PERDEU R$200");
    }


}

