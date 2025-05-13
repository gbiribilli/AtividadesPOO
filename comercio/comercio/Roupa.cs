using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Roupa:produto
{
    string tamanho;
    double preco;
    string tipo;
    public Roupa(string tipo,string tamanho, double preco) { 
        this.tamanho = tamanho;
        this.preco = preco;
        this.tipo = tipo;
    }
    public override void calcularPreco()
    {
        switch (tipo)
        {
            case "Esportivo":
                Console.WriteLine($"Roupas do tipo Esportivo estão pelo preço de R${preco}");
                break;
            case "Casual":
                Console.WriteLine($"Roupas do tipo Casual estão pelo preço de R${preco}");
                break;
        }
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Tipo:{tipo}\nTamanho:{tamanho}\nPreço:{preco}");
    }
}

