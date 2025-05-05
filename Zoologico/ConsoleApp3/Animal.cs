using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
public abstract class Animal: Visitavel
{
    protected string nome;
    protected int idade;

    public Animal(string nome,  int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
    public string Nome {  get { return nome; } }
    public int Idade { get { return idade; } }
    public abstract void EmitirSom();
    public abstract void Movimentar();
    public abstract void ExibirInformacoes();
}

