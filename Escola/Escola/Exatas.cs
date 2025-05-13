using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exatas : Disciplina
{   
    Dictionary<Aluno,int> Boletim = new Dictionary<Aluno, int>();

    public override void Matricular(Aluno aluno)
    {
      alunos.Add(aluno);
    }
    public override void CalcularNotas()
    {
        foreach (Aluno aluno in this.alunos)
        {
            Random random = new Random();
            int n = random.Next(1, 11);
            Boletim.Add(aluno, n);
        }  
    }
}

