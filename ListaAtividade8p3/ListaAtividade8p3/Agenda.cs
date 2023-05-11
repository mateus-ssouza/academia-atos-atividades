using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p3
{
    internal class Agenda
    {
        private List<Pessoa> _pessoas;

        public Agenda()
        {
            _pessoas = new List<Pessoa>();
        }

        public void armazenaPessoa(String nome, int idade, float altura)
        {
            Pessoa p = new Pessoa(nome, idade, altura);
            _pessoas.Add(p);
            Console.WriteLine("Pessoa adicionada!");
        }

        public void removePessoa(String nome)
        {

            for (int i = 0; i < _pessoas.Count; i++)
            {
                if (_pessoas[i].Nome == nome)
                {
                    _pessoas.RemoveAt(i);
                    Console.WriteLine("Pessoa removida!");
                    return;
                }
            }
        }

        public Pessoa buscaPessoa(String nome)
        {
            foreach (Pessoa p in _pessoas)
            {
                if (p.Nome == nome) return p;
            }

            return null;
        }

        public void imprimeAgenda()
        {
            foreach (Pessoa p in _pessoas)
            {
                Console.WriteLine(p);
            }
        }
    }
}
