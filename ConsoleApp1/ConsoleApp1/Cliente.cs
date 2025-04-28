using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente
{
    public string cpf;
    public double dinheiroEspecie;

    public void Sacar(double valor, Banco banco)
    {
        bool deuCerto = banco.Sacar(valor, cpf);
        if (deuCerto)
        {
            dinheiroEspecie += valor;
        }
    }

    public void Depositar(double valor, Banco banco)
    {
        bool deuCerto = banco.Depositar(valor, cpf);
        if (deuCerto)
        {
            dinheiroEspecie -= valor;
        }
    }
}
