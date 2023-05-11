using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa()
        {
            this.nome = "Pessoa";
            this.idade = 1;
        }

        public string Nome
        {
            get { return nome; }
            set { if (!String.IsNullOrEmpty(value)) nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }
    }
}
