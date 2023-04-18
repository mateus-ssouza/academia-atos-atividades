using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5)
    // e verifique se a soma dos elementos da diagonal principal é igual a
    // soma dos elementos da diagonal secundária.

    internal class Q13
    {
        public static void exec()
        {
            int[,] matriz = new int[5, 5];
            int diagonalPrincipal = 0;
            int diagonalSecundaria = 0;

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (i == j) diagonalPrincipal += matriz[i, j];
                    if (i + j == linha-1) diagonalSecundaria += matriz[i, j];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            if (diagonalPrincipal == diagonalSecundaria) Console.WriteLine("A soma dos valores de cada diagonal são iguais");
            else Console.WriteLine("A soma dos valores de cada diagonal não são iguais");
        }
    }
}
