using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Loja
{

    public abstract void VenderProduto(produto produto);
    public abstract void VenderProduto(produto produto, int quantidade);
    
}

