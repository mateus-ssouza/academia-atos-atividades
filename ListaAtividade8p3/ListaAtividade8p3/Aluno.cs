using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p3
{
    internal class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;

        public Aluno(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { if (!String.IsNullOrEmpty(value)) _nome = value; }
        }

        public double Nota1
        {
            get { return _nota1; }
            set { if (value >=0 &&  value <= 10) _nota1 = value;}
        }

        public double Nota2
        {
            get { return _nota2; }
            set { if (value >= 0 && value <= 10) _nota2 = value; }
        }

        public double Nota3
        {
            get { return _nota3; }
            set { if (value >= 0 && value <= 10) _nota3 = value; }
        }

        public double Media()
        {
            double media = (_nota1 + _nota2 + _nota3) / 3;
            return media;
        }

        public bool Situacao()
        {
            if (Media() >= 6) return true;
            return false;
        }
    }
}
