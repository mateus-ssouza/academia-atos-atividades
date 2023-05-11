using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p3
{
    internal class Autor
    {
        private string nome;

        public Autor(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get { return nome; }
            set { if (!String.IsNullOrEmpty(value)) nome = value; }
        }
    }
}
