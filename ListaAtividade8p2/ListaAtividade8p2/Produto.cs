using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class Produto
    {
        private string nome;
        private Fabricante fabricante;
        private double preco;

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public string Nome 
        { 
            get {  return nome; }
            set { if (!String.IsNullOrEmpty(value)) nome = value; }
        }

        public Fabricante Fabricante 
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { if(value > 0) preco = value; }
        }
    }
}
