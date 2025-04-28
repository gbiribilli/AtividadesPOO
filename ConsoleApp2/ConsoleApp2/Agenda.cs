using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Agenda
    {
        string nome;
        int telefone;
        public Agenda(string nome, int telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        Dictionary<string, int> agenda = new Dictionary<string, int>();
        public void adicionarAgenda(string nome,int telefone)
        {
            agenda.Add(nome, telefone);
        }

        public void buscarAgenda(string nome)
        {
          if (agenda.ContainsKey(nome))
          {
           Console.WriteLine(agenda[nome]);
            
          }
            else
            {
                Console.WriteLine("Não há esta pessoa na lista");
            }   
            
        }
        public void removerAgenda(string nome)
        {
            if (agenda.ContainsKey(nome))
            {
                agenda.Remove(nome);
            }
            else
            {
                Console.WriteLine("Não há esta pessoa na lista");
            }

        }
        public void mostrarAgenda()
        {
            foreach(var n in agenda)
            {
                Console.WriteLine($"{n.Key}:{n.Value}");
            }
        }
    }
}
