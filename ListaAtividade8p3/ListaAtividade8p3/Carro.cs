using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8p3
{
    internal class Carro
    {
        private string _modelo;
        private string _ano;
        private int _velocidade;

        public Carro(string modelo, string ano)
        {
            _modelo = modelo;
            _ano = ano;
        }

        public string Modelo 
        {
            get { return _modelo; }
            set { if (!String.IsNullOrEmpty(value)) _modelo = value; }
        }

        public string Ano
        {
            get { return _ano; }
            set { if (!String.IsNullOrEmpty(value)) _ano = value; }
        }

        public int Velocidade
        {
            get { return _velocidade; }
            set { if (value >= 0) _velocidade = value; }
        }

        public void Acelerar()
        {
            _velocidade += 10;
        }

        public void Frear()
        {
            if (_velocidade > 0)
            {
                _velocidade -= 10;
            }
        }

        public override string ToString()
        {
            return $"Carro: {Modelo}\nAno: {Ano}\nVelocidade: {Velocidade}KM";
        }
    }
}
