using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 12) Escreva um programa que leia os valores de uma matriz 4x3,
    // e em seguida mostre na tela apenas os valores cuja soma dos
    // índices (i+j) seja um número par.

    internal class Q12
    {
        public static void exec()
        {
            int[,] matriz = new int[4, 3];

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nValores: ");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if((i + j) % 2 == 0) Console.Write($"{matriz[i, j]} ");
                }
            }
        }
    }
}
