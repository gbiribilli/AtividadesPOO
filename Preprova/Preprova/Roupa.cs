using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Roupa:Produto
{
    private string tamanho;
    public Roupa(string nome,string cor, double preco,string tamanho) : base(nome, cor, preco)
    {
        this.tamanho = tamanho;
    }
    public string Tamanho{get{return tamanho;}}
}

