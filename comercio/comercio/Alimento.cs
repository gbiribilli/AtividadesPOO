using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alimento:produto
{
    string nome;
    string data;
    double preco;
    public Alimento(string nome, string data, double preco)
    {
        this.nome = nome;
        this.data = data;
        this.preco = preco;
    }

    public override void calcularPreco()
    {
        switch (nome)
        {
            case "Arroz":
                Console.WriteLine($"Preço do Arroz{nome}");
                break;
            case "Fruta":
                Console.WriteLine($"Preço da Fruta{nome}");
                break;
        }
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome:{nome}\nData:{data}\nPreço:{preco}");
    }
}

