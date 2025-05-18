using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alimento:Produto
{   DateTime data;
    public Alimento(string nome,string cor,double preco,DateTime data):base(nome, cor, preco)
    {
        this.data = data;
    }
    public DateTime Data{get{return data;}}
}

