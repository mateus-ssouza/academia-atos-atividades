using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 5) Leia duas matrizes 2x3 de números double.
    // Imprima a soma destas duas matrizes.

    internal class Q05
    {
        public static void exec()
        {
            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double[,] somaMatrizes = new double[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"M1 -> digite o valor [{i}][{j}]: ");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"M2 -> digite o valor [{i}][{j}]: ");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    somaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write($"{somaMatrizes[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
