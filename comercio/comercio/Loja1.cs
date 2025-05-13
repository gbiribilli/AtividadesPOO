using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Loja1:Loja,Estocavel
{
    Dictionary<produto, int> estoque = new Dictionary<produto, int>();

    public void Estocar(produto produto)
    {
        if (estoque.ContainsKey(produto))
        {
            estoque[produto] += 1;
        }
        else 
        {
            estoque.Add(produto, 1);
        }
        
    }

    public override void VenderProduto(produto produto)
    {
        Console.WriteLine($"{produto} Vendido");
    }

    public override void VenderProduto(produto produto, int quantidade)
    {
        Console.WriteLine($"{produto} Vendido");

        if (estoque.ContainsKey(produto))
        {
            estoque[produto] -= quantidade; 
        }
    }

    public void listarProdutos()
    {
        foreach (produto produto in estoque.Keys)
        {
            produto.ExibirInformacoes();
        }

    }
}

