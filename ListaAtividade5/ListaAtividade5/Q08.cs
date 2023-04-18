using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 8) Ler uma matriz com 4x4 de inteiros e mostrar
    // os números na ordem direta e inversa a que foram lidos.

    internal class Q08
    {
        public static void exec()
        {
            int[,] matriz = new int[4, 4];
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

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = linha - 1; i >= 0; i--)
            {
                for (int j = coluna - 1; j >= 0; j--)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
