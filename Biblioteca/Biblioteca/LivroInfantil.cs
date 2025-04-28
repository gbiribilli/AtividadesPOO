using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LivroInfantil:Livro
{
    public int idadeMinima;
    public LivroInfantil(string Titulo, string Autor,int idadeMinima) : base(Titulo, Autor)
    {
        this.idadeMinima = idadeMinima;
    }

}

