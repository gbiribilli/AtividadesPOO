using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Loja2:Loja,Estocavel
{
    List<produto> estoque = new List<produto>();

    public void Estocar(produto produto)
    {
            estoque.Add(produto);
    }
    public override void VenderProduto(produto produto)
    {
        if (estoque.Contains(produto))
        {
            Console.WriteLine($"{produto} vendido");
            estoque.Remove(produto);
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque");
        }
    }
    public override void VenderProduto(produto produto, int quantidade)
    {
        if (estoque.Contains(produto))
        {
            Console.WriteLine($"{produto} vendido");
            estoque.Remove(produto);
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque");
        }
    }

    public void listarProdutos()
    {
        foreach (produto produto in estoque)
        {
            produto.ExibirInformacoes();
            
        }

    }
}

