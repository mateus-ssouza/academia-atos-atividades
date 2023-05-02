using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(int idade)
        {
            this.nome = "---";
            this.idade = idade;
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
        }
    }
}
