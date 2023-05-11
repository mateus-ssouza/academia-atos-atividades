using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p3
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;
        private float _altura;

        public Pessoa(string nome, int idade, float altura)
        {
            _nome = nome;
            _idade = idade;
            _altura = altura;
        }

        public string Nome 
        { 
            get { return _nome;}
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nAltura: {Altura:N2}";
        }
    }
}
