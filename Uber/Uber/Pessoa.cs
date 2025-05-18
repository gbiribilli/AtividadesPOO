using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Pessoa
{
    protected List<Corrida> historicoDeCorridas = new List<Corrida>();
    string nome, cpf;
    int nota;
    public Pessoa(string nome, string cpf, int nota) { 
        this.nome = nome;
        this.cpf = cpf;
        this.nota = nota;
    }

    public abstract void Corridas();

}

