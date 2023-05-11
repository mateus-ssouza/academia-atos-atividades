using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p3
{
    internal class Livro
    {
        private string titulo;
        private Autor autor;

        public Livro(string titulo, Autor autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Titulo
        {
            get { return titulo; }
            set { if (!String.IsNullOrEmpty(value)) titulo = value; }
        }

        public Autor Autor
        {
            get { return autor; }
            set { if (value != null) autor = value; }
        }

        public void info()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor.Nome);
        }
    }
}
