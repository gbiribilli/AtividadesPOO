using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Corrida
{
    Pessoa pessoa;
    string data;
    string enderecoOrigem;
    string enderecoDestino;
    Motorista motorista;

    public Corrida(Pessoa pessoa, string data,string enderecoOrigem,string enderecoDestino,Motorista motorista)
    {
        this.pessoa = pessoa;
        this.data = data;
        this.motorista = motorista;
        this.enderecoDestino = enderecoDestino;
        this.enderecoOrigem = enderecoOrigem;
    }

}


