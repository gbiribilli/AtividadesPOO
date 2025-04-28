using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Elevador
    {
        // False: Porta fechada 
        // True: Porta Aberta
        private int andarAtual = 1;
        private bool porta = false;
        private double pesoAtual = 0;
        private const double pesoMaximo = 800;
        public bool Porta
        {
            get { return porta; }
        }
        public void AbrirPorta()
        {     
            if(!porta) {
                Console.WriteLine("Abrindo portas");
                porta= true;
            }
            else {
                Console.WriteLine("As portas ja estão abertas");
            }
          
        }
        public void fecharPorta()
        {
            bool porta = Porta;
            if(porta)
            {
                Console.WriteLine("Fechando portas");
                porta=  false;
            }
            else
            {
                Console.WriteLine("Portas ja estão fechadas");
                
            }
        }
        public void entrar(double pesoUsuario, int andarDestino)
        {
            if (!porta)
            {
                Console.WriteLine("As portas estão fechadas! Abra antes de entrar.");
                return;
            }

            if (pesoAtual + pesoUsuario > pesoMaximo)
            {
                Console.WriteLine("Peso máximo atingido! Usuário não pode entrar.");
                return;
            }

            pesoAtual += pesoUsuario;
            Console.WriteLine($"Usuário entrou no elevador e deseja ir para o andar {andarDestino}");

            fecharPorta();
            MoverParaAndar(andarDestino);
        }
        public void MoverParaAndar(int andarDestino)
        {
            if (andarDestino < 1 || andarDestino > 8)
            {
                Console.WriteLine("Andar não existente.");
                return;
            }

            if (porta)  // O elevador não pode se mover com a porta aberta
            {
                Console.WriteLine("Feche as portas antes de se mover!");
                return;
            }

            while (andarAtual != andarDestino)
            {
                if (andarAtual < andarDestino)
                {
                    andarAtual++;
                }
                else
                {
                    andarAtual--;
                }
                Console.WriteLine($"Passando pelo andar {andarAtual}");
            }

            AbrirPorta();  // Abre a porta ao chegar no destino
        }
    }
}
