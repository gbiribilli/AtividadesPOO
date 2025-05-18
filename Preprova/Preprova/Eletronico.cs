using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Eletronico : Produto
{
    private bool garantia = false;
    public Eletronico(string nome, string cor,double preco,bool garantia) :base (nome,cor,preco)
    {
        this.garantia = garantia;
    }
    public bool Garantia{get{return garantia;}} 
}

