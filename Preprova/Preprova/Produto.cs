using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Produto
{
   private string nome;
   private string cor;
   private double preco;
    public Produto(string nome,string cor,double preco)
    {
        this.nome = nome;
        this.cor = cor;
        this.preco = preco;
    }
    public string Nome { get { return this.nome; } }
    public string Cor { get { return this.cor; } }
    public double Preco {  get { return this.preco; } } 
}

