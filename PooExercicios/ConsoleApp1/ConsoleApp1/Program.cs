using System;
using System.Collections.Generic;

/*class Livro
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int AnoPublicacao { get; private set; }
    public bool EstaAlugado { get; private set; }

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        EstaAlugado = false;
    }

    public void Alugar()
    {
        if (!EstaAlugado)
        {
            EstaAlugado = true;
            Console.WriteLine($"Livro '{Titulo}' alugado com sucesso!");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' já está alugado.");
        }
    }

    public void Devolver()
    {
        if (EstaAlugado)
        {
            EstaAlugado = false;
            Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso!");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' não está alugado.");
        }
    }

    public override string ToString()
    {
        return $"{Titulo} - {Autor} ({AnoPublicacao}) - {(EstaAlugado ? "Alugado" : "Disponível")}";
    }
}

class Biblioteca
{
    private List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void AlugarLivro(string titulo)
    {
        Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livro.Alugar();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    public void DevolverLivro(string titulo)
    {
        Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    public void ListarLivros()
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("A biblioteca está vazia.");
        }
        else
        {
            Console.WriteLine("Lista de livros na biblioteca:");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }
    }
}
*/
/*public class Carro
{
    public int qualidadeRodas = 100;

    public void Aclerar()
    {
        if (qualidadeRodas <= 0)
        {
            Console.WriteLine("Carro não pode acelerar, necessario fazer PitStop");
        }
        else
        {
            Console.WriteLine("Vruuumm");
            qualidadeRodas -= 10;
        }
    }
}
class Mecanico
{
    public void PiStop(Carro carro)
    {
        carro.qualidadeRodas = 100;
        Console.WriteLine("PitStop Realizado");
    }
}*/
public class Personagem
{
    int vida = 100;
    int DefesaAtacado= 4;
    public void Ataque(int DanoAtacante,string Jogador)
    {   
        if(vida <= 0)
        {
            Console.WriteLine("Personagem ja esta morto");
        }
        else
        {   
            vida = vida - (DanoAtacante - DefesaAtacado);
            Console.WriteLine($"{Jogador} - Possui: {vida} de HP");
            Console.WriteLine("\n");
        } 
        
    }
}
class Program
{
    static void Main()
    {
        Personagem player1 = new Personagem();
        Personagem player2 = new Personagem();
        Random numero = new Random();
        Console.WriteLine("Vida inicial: 100");
        for(int i = 0; i < 5; i++)
        {   
            
            int n = numero.Next(1, 21);
            player1.Ataque(n,"Jogador1");
            Console.WriteLine($"Jogador1 causou: {n}");
            Console.WriteLine("\n");
            int j = numero.Next(1, 21);
            player2.Ataque(j,"Jogador2");
            Console.WriteLine($"Jogador 2 causou: {n}");

        }
        /*Carro carro = new Carro();
       for(int i = 0; i < 11; i++)
        {
            carro.Aclerar();
        }

        Mecanico mecanico = new Mecanico();
        mecanico.PiStop(carro);
        carro.Aclerar();
        /*  Biblioteca biblioteca = new Biblioteca();

 biblioteca.AdicionarLivro(new Livro("1984", "George Orwell", 1949));
 biblioteca.AdicionarLivro(new Livro("Dom Casmurro", "Machado de Assis", 1899));
 biblioteca.AdicionarLivro(new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954));

 biblioteca.ListarLivros();

 biblioteca.AlugarLivro("1984");
 biblioteca.AlugarLivro("1984"); // Teste de livro já alugado

 biblioteca.ListarLivros();

 biblioteca.DevolverLivro("1984");
 biblioteca.ListarLivros();*/

    }
}



