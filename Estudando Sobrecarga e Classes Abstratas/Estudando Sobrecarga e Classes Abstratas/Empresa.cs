using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empresa
{   
    public List<Funcionario> funcionarios = new List<Funcionario>();

    public void darAumento()
    {
        foreach (Funcionario f in funcionarios)
        {   
            f.receberAumentoAnual();
        }
    }

    public void trabalharF()
    {
        foreach (Funcionario f in funcionarios)
        {
            if (f is Gerente)
            {
                Console.WriteLine("Gerente não trabalha");
            }
            else if(f is FuncionarioTrabalhador trabalhador)
            {
                trabalhador.trabalhar();
            }
        }
    }
    public void listarFuncionario()
    {
        foreach(Funcionario f  in funcionarios)
        {
            Console.WriteLine($"Nome:{f.nome}\nSalario:{f.salario}");
        }
    }
}

