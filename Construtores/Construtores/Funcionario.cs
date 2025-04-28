using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Funcionario
    {
        private string nome;
        private string Sobrenome;
        private double Salario;
        public Funcionario(string nome,string Sobrenome,double Salario)
        {
            this.Salario = Salario;
            this.Sobrenome = Sobrenome;
            this.nome = nome;
        }
        public void dadosFuncionario()
        {
            Console.WriteLine($"Nome: {this.nome}\nSobrenome: {this.Sobrenome}\nSalario Anual: {this.Salario * 12}");
        }
    }
}
