using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class Conta
    {
        private int numero;
        private double saldo;
        private double limite;

        public Conta(int numero)
        {
            this.numero = numero;
            this.saldo = 0;
            this.limite = 1000;
        }

        public int Numero
        {
            get { return numero; }
        }

        public double Saldo 
        { 
            get { return saldo; }
            set { if (value >= 0) saldo = value; }
        }

        public double Limite
        {
            get { return limite; }
            set { if (value > 0) limite = value; }
        }
    }
}
