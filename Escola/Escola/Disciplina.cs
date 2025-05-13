using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
public abstract class Disciplina
{
    protected List<Aluno> alunos = new List<Aluno>();

    public abstract void Matricular(Aluno aluno);

    public abstract void CalcularNotas();
}

