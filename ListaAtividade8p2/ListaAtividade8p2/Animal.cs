using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class Animal
    {
        private string _nome;
        private string _especie;
        private int _idade;

        public Animal(string nome, string especie, int idade)
        {
            _nome = nome;
            _especie = especie;
            _idade = idade;
        }

        public string Nome 
        { 
            get { return _nome; }
            set { if (!String.IsNullOrEmpty(value)) _nome = value; }
        }

        public string Especie 
        { 
            get { return _especie; }
            set { if (!String.IsNullOrEmpty(value)) _especie = value; }
        }
        public int Idade 
        { 
            get { return _idade; }
            set { if (value > 0) _idade = value; }
        }

        public void EmitirSom()
        {
            Console.WriteLine("O animal fez um som!");
        }
    }
}
