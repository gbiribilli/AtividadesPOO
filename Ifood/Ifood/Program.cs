using Ifood;

Cliente c = new Cliente("Biribilli", 10);
empresaIfood i = new empresaIfood();
Entregador ent = new Entregador("guilherme", "Moto",i);

Entregador entr = new Entregador("gui", "Bicicleta", i);
PizzaTower pizza = new PizzaTower();

string escolha;
Console.WriteLine("Olá, o que deseja comer hoje?");
escolha =Console.ReadLine();

switch (escolha)
{
    case "pizza":
        string sabor;
        Console.WriteLine("Escolha um sabor:");
        sabor = Console.ReadLine();
        pizza.pedirPizza(c, sabor, i);
        break;

    case "Esfirra":
        string saborr;
        Console.WriteLine("Escolha um sabor:");
        sabor = Console.ReadLine();
        break;
}

