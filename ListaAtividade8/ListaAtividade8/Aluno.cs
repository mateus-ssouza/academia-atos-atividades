using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade8
{
    internal class Aluno
    {
        public string nome;
        public string dataNascimento;
        public string matricula;
        public string anoDeIngresso;

        public Aluno(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.dataNascimento = "--";
            this.anoDeIngresso = "--";
        }

        public Aluno(string dataNascimento)
        {
            this.nome = "--";
            this.matricula = "--";
            this.dataNascimento = dataNascimento;
            this.anoDeIngresso = "--";
        }

        public Aluno(string nome, string dataNascimento, string anoDeIngresso)
        {
            this.nome = nome;
            this.matricula = "---";
            this.dataNascimento = dataNascimento;
            this.anoDeIngresso = anoDeIngresso;
        }

        public void exibirDados()
        {
            Console.WriteLine("\nNome: " + this.nome);
            Console.WriteLine("Data de nascimento: " + this.dataNascimento);
            Console.WriteLine("Matrícula: " + this.matricula);
            Console.WriteLine("Ano de ingresso: " + this.anoDeIngresso);
        }
    }
}
