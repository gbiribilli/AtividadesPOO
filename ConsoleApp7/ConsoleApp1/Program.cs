using System;
using System.Collections.Generic;

// Interface para aumento de salário
interface IAumentoSalario
{
    void AumentarSalario(double porcentagem);
}

// Classe abstrata base
abstract class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double SalarioBase { get; set; }

    public Funcionario(string nome, int idade, double salarioBase)
    {
        Nome = nome;
        Idade = idade;
        SalarioBase = salarioBase;
    }

    public abstract double CalcularSalario();
}

// Funcionário regular
class FuncionarioRegular : Funcionario
{
    public FuncionarioRegular(string nome, int idade, double salarioBase)
        : base(nome, idade, salarioBase) { }

    public override double CalcularSalario()
    {
        return SalarioBase; // Salário fixo
    }
}

// Gerente com bonificação
class Gerente : Funcionario, IAumentoSalario
{
    public double Bonificacao { get; set; }

    public Gerente(string nome, int idade, double salarioBase, double bonificacao)
        : base(nome, idade, salarioBase)
    {
        Bonificacao = bonificacao;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonificacao;
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBase += SalarioBase * (porcentagem / 100);
    }
}

// Diretor com participação nos lucros
class Diretor : Funcionario, IAumentoSalario
{
    public double ParticipacaoLucros { get; set; }

    public Diretor(string nome, int idade, double salarioBase, double participacaoLucros)
        : base(nome, idade, salarioBase)
    {
        ParticipacaoLucros = participacaoLucros;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + ParticipacaoLucros;
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBase += SalarioBase * (porcentagem / 100);
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        FuncionarioRegular f1 = new FuncionarioRegular("Ana", 28, 3000);
        Gerente g1 = new Gerente("Bruno", 35, 5000, 1000);
        Diretor d1 = new Diretor("Carla", 45, 8000, 2000);

        funcionarios.Add(f1);
        funcionarios.Add(g1);
        funcionarios.Add(d1);

        Console.WriteLine("Salários iniciais:");
        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($"{f.Nome}: R$ {f.CalcularSalario():F2}");
        }

        // Aumentando salários dos que implementam a interface
        g1.AumentarSalario(10); // 10% para o gerente
        d1.AumentarSalario(15); // 15% para o diretor

        Console.WriteLine("\nSalários após aumento:");
        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($"{f.Nome}: R$ {f.CalcularSalario():F2}");
        }
    }
}
