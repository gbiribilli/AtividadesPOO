using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class UsuarioElevador
    {
        private double pesoUsuario;
        private string nome;
        private Elevador elevador;
        public int andarDestino;
        
        public UsuarioElevador(string nome, double pesoUsuario, Elevador elevador)
        {
            this.pesoUsuario = pesoUsuario;
            this.nome = nome;
            this.elevador = elevador;
        }
        Random r = new Random();
       
        public void EntrarNoElevador()
        {
            andarDestino = r.Next(1, 9);
            elevador.AbrirPorta();
            elevador.entrar(pesoUsuario, andarDestino);
        }
    }

}

