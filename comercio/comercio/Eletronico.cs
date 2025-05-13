using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Eletronico:produto
{
    string marca, modelo;
    double preco;
    const int Samsung = 300;
    const int Xiaomi = 500;
    const int Iphone = 2000000;
    double imposto = 0.25;
    public Eletronico(string marca, string modelo, double preco) {
        this.marca = marca;
        this.modelo = modelo;
        this.preco = preco;
    }
    public override void calcularPreco()
    {
        switch (marca)
        {
            case "Samsung":
                Console.WriteLine($"O celular Samsung esta saindo por: R${Samsung +(Samsung * imposto)}");
                break;
            case "Xiamoi":
                Console.WriteLine($"O celular Xiaomi esta saindo por: R${Xiaomi +(Xiaomi * imposto)}");
                break;
            case "Iphone":
                Console.WriteLine($"O celular Iphone esta saindo por: R${Iphone + (Iphone * imposto)}");
                break;
        }
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}\nModelo:{modelo}\nPreço:{preco}");
    }

}

