using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class FuncionarioTrabalhador : Funcionario
{   

    public FuncionarioTrabalhador(string nome, double salario) : base(nome, salario) {

    }
    public override void receberAumentoAnual()
    {
        salario += (salario *0.10);
    }
    public abstract void trabalhar();
}

