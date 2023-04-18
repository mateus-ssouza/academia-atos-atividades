using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
    // A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o
    // dobro dos elementos da 1ª coluna.

    internal class Q01
    {
        public static void exec()
        {
            int[,] matriz = new int[5,3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"Digite o valor [{i}][0]: ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
