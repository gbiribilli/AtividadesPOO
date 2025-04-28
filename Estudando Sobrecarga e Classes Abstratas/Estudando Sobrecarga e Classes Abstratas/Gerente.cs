using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gerente: Funcionario
{
    public Gerente(string nome,double salario): base(nome, salario)
    {

    }

    public override void receberAumentoAnual()
    {
        salario += (salario *0.20);
    }
}

