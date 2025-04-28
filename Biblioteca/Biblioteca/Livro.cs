using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Livro
{   
    protected string Titulo;
    protected string Autor;
    public Livro(string Titulo, string Autor)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
    }
    public string titulo { get { return Titulo; } }
    public string autor { get { return Autor; } }

}

