using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 11) Leia uma matriz A de tipo double de dimenção 3x3,
    // crie uma nova matriz resultante da divisão dos elementos
    // da matriz A pela soma dos seus indices.

    internal class Q11
    {
        public static void exec()
        {
            double[,] matrizA = new double[3, 3];
            double[,] matrizR = new double[3, 3];

            int linha = matrizA.GetLength(0);
            int coluna = matrizA.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matrizA[i, j] = double.Parse(Console.ReadLine());

                    if (i == 0 && j == 0) matrizR[i, j] = matrizA[i, j];
                    else matrizR[i, j] = matrizA[i, j] / (i + j);
                }
            }
            
            Console.WriteLine();

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matrizA[i, j]:N2} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matrizR[i, j]:N2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
