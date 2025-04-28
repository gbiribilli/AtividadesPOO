using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Banco
{
    private double dinheiroCaixa = 1000;

    private Dictionary<string, double> contas = 
        new Dictionary<string, double>();

    public bool CriarConta(string cpf)
    {
        if(contas.ContainsKey(cpf))
        {
            return false;
        } else
        {
            contas.Add(cpf, 0);
            return true;
        }
    }

    public bool Sacar(double valor, string cpf)
    {
        if(!contas.ContainsKey(cpf))
        {
            return false;
        }

        double saldo = contas[cpf];

        if (saldo < valor)
        {
            return false;
        }

        if(dinheiroCaixa < valor)
        {
            return false;
        }

        saldo = saldo - valor;
        contas[cpf] = saldo;
        dinheiroCaixa -= valor;

        return true;
    }

    public bool Depositar(double valor, string cpf)
    {
        if(!contas.ContainsKey(cpf))
        {
            return false;
        }

        contas[cpf] += valor;
        dinheiroCaixa += valor;

        return true;
    }
}
