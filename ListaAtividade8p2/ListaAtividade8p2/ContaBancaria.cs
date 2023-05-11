using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p2
{
    internal class ContaBancaria
    {
        private string _numeroConta;
        private string _titular;
        private double _saldo;
        private double _limite;

        public ContaBancaria(string numeroConta, string titular, double saldo, double limite)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = saldo;
            _limite = limite;
        }

        public string NumeroConta
        {
            get { return _numeroConta; }
            set { if (!String.IsNullOrEmpty(value)) _numeroConta = value; }
        }

        public string Titular
        {
            get { return _titular; }
            set { if (!String.IsNullOrEmpty(value)) _titular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { if (value > 0) _saldo = value; }
        }

        public double Limite
        {
            get { return _limite; }
            set { if (value > 0) _limite = value; }
        }

        public bool Depositar(double deposito)
        {
            if (deposito > 0)
            {
                _saldo += deposito;
               return true;
            }
            return false;
        }

        public bool Sacar(double saque)
        {
            if (saque > 0 && saque <= (Saldo + Limite))
            {
                _saldo -= saque;
                return true;
            }
            return false;
        }
    }
}
