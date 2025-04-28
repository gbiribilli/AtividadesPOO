using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Designer:FuncionarioTrabalhador
{
    public Designer(string nome,double salario) : base(nome, salario)
    {

    }
    public override void trabalhar()
    {
        Console.WriteLine($"{nome} está Criando Arte");
    }
}

