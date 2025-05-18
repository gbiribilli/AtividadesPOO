using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exatas : Disciplina
{
    int media = 6;
    Dictionary<Aluno,int> Boletim = new Dictionary<Aluno, int>();

    public override void Matricular(Aluno aluno)
    {
      alunos.Add(aluno);
      Console.WriteLine("Aluno matriculado");
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
    public void ListarNotas()
    {
        foreach(var alunos in Boletim)
        {   
            if(alunos.Value >= media)
            {
                Console.WriteLine($"Nome: {alunos.Key}| Nota:{alunos.Value}| APROVADO");
            }
            else
            {
                Console.WriteLine($"Nome: {alunos.Key}| Nota:{alunos.Value}| REPROVADO");
            }
        }
    }

}

