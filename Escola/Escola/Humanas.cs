using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Humanas:Disciplina
{
    int media = 6;
    int presencaParaPassar = 75;
    Dictionary<Aluno,int> Boletim = new Dictionary<Aluno,int>();
    public override void CalcularNotas()
    {
        foreach (Aluno aluno in this.alunos)
        {   
            Random random = new Random();
            int n = random.Next(1, 11);
            Boletim.Add(aluno, n);
        }
    }
    /*public void ListarNotas()
    {
        foreach (var alunos in Boletim)
        {
            if (alunos.Value >= media && presenca >= 75)
            {
                Console.WriteLine($"Nome: {alunos.Key}| Nota:{alunos.Value}| APROVADO");
            }
            else if((alunos.Value >= media && presenca < 75) || (alunos.Value < media && presenca >= 75))
            {
                Console.WriteLine($"Nome: {alunos.Key}| Nota:{alunos.Value}| REPROVADO");
            }
        }
    }*/
    public override void Matricular(Aluno aluno)
    {
        alunos.Add(aluno);
    }

   
}

