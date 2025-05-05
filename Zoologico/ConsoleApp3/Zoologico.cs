using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Zoologico
{
   private List<Animal> animais = new List<Animal>();
   
    public void adicionarAnimal(Animal a)
    {
        if (animais.Contains(a))
        {
            Console.WriteLine("Animal existente");
        }
        else
        {
            animais.Add(a);
        }
            
    }

    public void ObservarAnimal(int index)
    {
        animais[index].ExibirInformacoes();
    }
    public int QuantidadeAnimais()
    {
        Console.WriteLine($"Temos {animais.Count} Animais em nosso Zoológico");
        return animais.Count;
    }

    public List<Animal> Animaiss {  get { return animais; } }
}

