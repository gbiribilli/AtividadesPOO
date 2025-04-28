using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Programador:FuncionarioTrabalhador
{
    public Programador(string nome,double salario) : base(nome,salario){ 

    }
    public override void trabalhar()
    {
        Console.WriteLine($"{nome} está Programando");
    }
}

