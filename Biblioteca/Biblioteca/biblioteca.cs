using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class biblioteca
{
   public List<Livro> Livros = new List<Livro>();

    public void buscarLivro(int idadeMinima)
    {
        foreach (Livro l in Livros)
        {
            if (l is LivroInfantil li)
            {
                if (li.idadeMinima <= idadeMinima)
                {
                    Console.WriteLine($"Titulo:{l.titulo}\nAutor:{l.autor}");
                }

            }
        }
    }
    public void buscarLivro(string ORCID)
    {
        foreach (Livro l in Livros)
        {
            if (l is LivroAcademico la)
            {
                if (la.ORCID == ORCID)
                {
                    Console.WriteLine($"Titulo:{la.titulo}\nAutor:{la.autor}");
                }
            }
        }
    }
}

