using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 7) Leia duas matrizes A e B com 3x3 elementos.
    // Construir uma matriz C, onde cada elemento de
    // C é a subtração do elemento correspondente de A com B.

    internal class Q07
    {
        public static void exec()
        {
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"MA -> digite o valor [{i}][{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"MB -> digite o valor [{i}][{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMATRIZ C");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                    Console.Write($"{matrizC[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
