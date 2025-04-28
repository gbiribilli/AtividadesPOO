using exercicios2704;
using System;
using System.Collections.Generic;

/*abstract class Animal
{
    public abstract void EmitirSom();
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro faz: Au Au!");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato faz: Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animais = new List<Animal>();

        animais.Add(new Cachorro());
        animais.Add(new Gato());

        foreach (Animal animal in animais)
        {
            animal.EmitirSom();
        }
    }
}

/*
Arqueiro rogerio = new Arqueiro("Rogerio", "Vento", 10);
Guerreiro ghost = new Guerreiro("Ghost", "Melancolia");

rogerio.atacar(ghost);
Console.WriteLine();
ghost.atacar(rogerio);
Console.WriteLine();

rogerio.situacaoPersonagem();
Console.WriteLine();
ghost.situacaoPersonagem();*/

List<FormaGeometrica> formas = new List<FormaGeometrica>();

Triangulo t = new Triangulo(10,5);
Retangulo r = new Retangulo(10, 10);
Quadrado q = new Quadrado(5);
Circulo c = new Circulo(15);

formas.Add(c);
formas.Add(q);
formas.Add(t);
formas.Add(r);

foreach(FormaGeometrica forma in formas)
{
    forma.CalcularArea();
}
