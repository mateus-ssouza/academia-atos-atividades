using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q11
    {
        public static void exec()
        {
            /* 11. Ler as notas de uma turma de alunos e ao final 
             * imprimir a nota mais alta, a nota mais baixa, a média 
             * aritmética da turma e a quantidade de alunos da turma. 
             * Usar -1 para encerrar a leitura.
             */

            double somaNotas = 0;
            double notaMaisAlta = int.MinValue;
            double notaMaisBaixa = int.MaxValue;
            double notas;
            int quantidadeAlunos = 0;

            Console.WriteLine("Digite as notas dos alunos (-1 para encerrar):");

            while (true)
            {
                notas = double.Parse(Console.ReadLine());

                if (notas <= -1) break;

                if (notas > notaMaisAlta) notaMaisAlta = notas;

                if (notas < notaMaisBaixa) notaMaisBaixa = notas;

                somaNotas += notas;
                quantidadeAlunos++;
            }

            if (quantidadeAlunos > 0)
            {
                Console.WriteLine("Nota mais alta: " + notaMaisAlta);
                Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
                Console.WriteLine("Média da turma: " + (somaNotas / quantidadeAlunos));
                Console.WriteLine("Quantidade de alunos: " + quantidadeAlunos);
            }
            else Console.WriteLine("Nenhuma nota foi digitada.");
        }
    }
}
