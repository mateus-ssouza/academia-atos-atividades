using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 15) Escreva um programa em C# para ler os valores
    // e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

    internal class Q15
    {
        public static void exec()
        {
            int linha = 4;
            int coluna = 4;

            int[,] matrizA = new int[linha, coluna];
            int[,] matrizB = new int[linha, coluna];
            int[,] matrizC = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"MA -> digite o valor [{i}][{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"MB -> digite o valor [{i}][{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMATRIZ C");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.Write($"{matrizC[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
