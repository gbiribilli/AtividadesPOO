using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Loja
{
  
    List<Produto> ListaDeProdutos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        ListaDeProdutos.Add(produto);
    }

    public List<Produto> ProcurarProduto(string produto)
    {
        List<Produto> Encontrados = new List<Produto>();
        foreach (var produtos in ListaDeProdutos)
        {
            if (produtos.Nome == produto) { 
                Encontrados.Add(produtos);
            }
        }
        return Encontrados;
    }

    public List<Produto> ProcurarProduto(string produto, double preco)
    {
        List<Produto> Encontrados = new List<Produto>();
        foreach (var produtos in ListaDeProdutos)
        {
            if (produtos.Nome == produto && produtos.Preco == preco)
            {
                Encontrados.Add(produtos);
            }
        }
        return Encontrados;
    }
    public List<Produto> ProcurarProduto(string produto, double preco, string cor)
    {
        List<Produto> Encontrados = new List<Produto>();
        foreach (var produtos in ListaDeProdutos)
        {
            if (produtos.Nome == produto && produtos.Cor == cor && produtos.Preco == preco)
            {
                Encontrados.Add(produtos);
            }
        }
        return Encontrados;
    }

    public void RemoverProduto(Produto produto)
    {
        if (ListaDeProdutos.Contains(produto))
        {
            ListaDeProdutos.Remove(produto);
        }
        else
        {
            Console.WriteLine("Produto não existe");
        }
    }

    public void Descrever()
    {
        Console.WriteLine($"=== PRODUTOS DA LOJA ({ListaDeProdutos.Count} produtos) ===");
    
        if (ListaDeProdutos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado na loja.");
            return;
        }
    
        foreach (var produto in ListaDeProdutos)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");
            Console.WriteLine($"Cor: {produto.Cor}");
        
            switch (produto)
            {
                case Alimento alimento:
                    Console.WriteLine($"Data de Fabricação: {alimento.Data:dd/MM/yyyy}");
                    break;
                case Eletronico eletronico:
                    Console.WriteLine($"Garantia: {(eletronico.Garantia ? "Sim" : "Não")}");
                    break;
                case Roupa roupa:
                    Console.WriteLine($"Tamanho: {roupa.Tamanho}");
                    break;
            }
            Console.WriteLine("---");
        }
    
        Console.WriteLine("=== FIM DA LISTA ===");
    }
}

