using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LivroAcademico : Livro { 

    public string ORCID;
    public LivroAcademico(string Titulo, string Autor, string ORCID) : base(Titulo, Autor)
    {
        this.ORCID = ORCID;
    }

}
