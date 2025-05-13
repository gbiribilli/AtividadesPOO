using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluno
{
    string nome, cpf;
    public Aluno(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }

    public void matricular(Disciplina disciplina)
    {
        disciplina.Matricular(this);
    }

}

