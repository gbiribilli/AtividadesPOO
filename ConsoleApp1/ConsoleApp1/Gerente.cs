using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gerente :Funcionario, AumentoSalario
{
    double bonus;
    public Gerente(string nome,int idade,double salarioBase,double bonus) : base(nome, idade, salarioBase)
    {
     this.bonus = bonus;
    }
    public override void CalcularSalario()
    {
        Console.WriteLine($"R${salarioBase}");
    }
    public void AumentarSalario(int porcentagem)
    {
        salarioBase = salarioBase + (salarioBase * (porcentagem / 100));
        Console.WriteLine($"Salario atual: R${salarioBase}");
    }
}

