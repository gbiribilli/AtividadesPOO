using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Humanas:Disciplina
{   
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
    public void ListarNotas()
    {
        foreach (KeyValuePair<Aluno, int> na in Boletim)
        {
            Console.WriteLine($"Nome:{na.Key} | Nota:{na.Value}");
        }
    }
}

