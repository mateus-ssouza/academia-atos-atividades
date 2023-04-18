using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

    internal class Q03
    {
        public static void exec()
        {
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(i == j) Console.Write($"{matriz[i, j]} ");
                }
            }
        }
    }
}
