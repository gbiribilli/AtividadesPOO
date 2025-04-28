using Carros;

 string[] cor = { "Azul", "Vermelho", "Verde" };
int azul = 0;
int vermelho = 0;
int verde = 0;

for(int i = 0; i < 1000; i++)
{
    Random r = new Random();
    int n = r.Next(0, 3);
    Carro carro = new Carro();
    carro.cor = cor[n];

    switch (n)
    {
        case 0:
            azul++;
       break;

        case 1:
            vermelho++;
        break;
        case 2:
            verde++;
            break;
    }
    carro.mostrar();
}

Console.WriteLine($"Vermelho: {vermelho}\nAzul: {azul}\nVerde: {verde}");