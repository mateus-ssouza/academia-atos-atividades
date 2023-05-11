using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class Aluno
    {
        public string _nome;
        public int _matricula;

        public Aluno(string nome, int matricula)
        {
            _nome = nome;
            _matricula = matricula;
        }

        public string Nome
        {
            get { return _nome; }
            set { if (!String.IsNullOrEmpty(value)) _nome = value; }
        }

        public int Matricula
        {
            get { return _matricula; }
            set { if (value > 0) _matricula = value; }
        }
    }
}
