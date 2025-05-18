using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exatas : Disciplina
{   
    Dictionary<Aluno,int> Boletim = new Dictionary<Aluno, int>();
    private int media = 6;
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

    public void ListarNotas()
    {
        foreach(var alunos in Boletim)
        {   
            if(alunos.Value >= media)
            {
                Console.WriteLine($"Nome: {alunos.Key.ToString()}| Nota:{alunos.Value}| APROVADO");
            }
            else
            {
                Console.WriteLine($"Nome: {alunos.Key}| Nota:{alunos.Value}| REPROVADO");
            }
        }
    }
    
}

