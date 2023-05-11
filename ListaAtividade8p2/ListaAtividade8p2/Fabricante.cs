using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public Fabricante(string nome, string endereco, string cidade)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cidade = cidade;
        }

        public string Nome
        {
            get { return nome; }
            set { if(!String.IsNullOrEmpty(value)) nome = value; }
        }

        public string Endereco 
        { 
            get { return endereco; } 
            set { nome = value; }
        }
        
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
