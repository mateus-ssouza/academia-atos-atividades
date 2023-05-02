using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8
{
    internal class ContaCorrente
    {
        public double saldo;


        public void definirSaldoInicial(double saldo)
        {
            if (saldo > 0) this.saldo = saldo;
            else this.saldo = 0;
        }

        public void depositar(double saldo)
        {
            if (saldo > 0) this.saldo += saldo;
        }

        public bool sacar(double saldo)
        {
            if ((this.saldo - saldo) >= 0)
            {
                this.saldo -= saldo;
                return true;
            }
            else return false;
        }

        public double saldoAtual()
        {
            return this.saldo;
        }
    }
}
