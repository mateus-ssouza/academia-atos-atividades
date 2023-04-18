using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média
    // dos mesmos, em seguida, diga quantos dos elementos lidos estão
    // abaixo, acima e na média.

    internal class Q10
    {
        public static void exec()
        {
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];

            int linhaA = matrizA.GetLength(0);
            int colunaA = matrizA.GetLength(1);

            int linhaB = matrizB.GetLength(0);
            int colunaB = matrizB.GetLength(1);

            int somaA = 0;
            int somaB = 0;
            int totalElementosA = linhaA + colunaA;
            int totalElementosB = linhaB + colunaB;
            int totalAcimaDaMedia = 0;
            int totalAbaixoDaMedia = 0;
            int totalNaMedia = 0;
            double media;

            for (int i = 0; i < linhaA; i++)
            {
                for (int j = 0; j < colunaA; j++)
                {
                    Console.Write($"MA -> digite o valor [{i}][{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                    somaA += matrizA[i, j];
                }
            }

            for (int i = 0; i < linhaB; i++)
            {
                for (int j = 0; j < colunaB; j++)
                {
                    Console.Write($"MB -> digite o valor [{i}][{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                    somaB += matrizB[i, j];
                }
            }

            media = Math.Ceiling((double)(somaA + somaB) / (totalElementosA + totalElementosB));

            for (int i = 0; i < linhaA; i++)
            {
                for (int j = 0; j < colunaA; j++)
                {
                    if (matrizA[i, j] > media) totalAcimaDaMedia++;
                    else if (matrizA[i, j] < media) totalAbaixoDaMedia++;
                    else totalNaMedia++;
                }
            }

            for (int i = 0; i < linhaB; i++)
            {
                for (int j = 0; j < colunaB; j++)
                {
                    if (matrizB[i, j] > media) totalAcimaDaMedia++;
                    else if (matrizB[i, j] < media) totalAbaixoDaMedia++;
                    else totalNaMedia++;
                }
            }

            Console.WriteLine($"\nTotal números na média: {totalNaMedia}");
            Console.WriteLine($"Total números acima da média: {totalAcimaDaMedia}");
            Console.WriteLine($"Total números abaixo da média: {totalAbaixoDaMedia}");
        }
    }
}
