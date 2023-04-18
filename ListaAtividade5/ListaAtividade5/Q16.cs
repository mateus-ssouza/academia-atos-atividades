using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
    // Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

    internal class Q16
    {
        public static void exec()
        {
            int[,] matriz = new int[3, 4];

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            int[,] matrizT = new int[coluna, linha];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    matrizT[i, j] = matriz[j, i];
                }
            }

            Console.WriteLine("\nMATRIZ");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMATRIZ T");
            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    Console.Write($"{matrizT[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
