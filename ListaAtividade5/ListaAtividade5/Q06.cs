using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9.
    // Após isso determine o maior número da matriz.

    internal class Q06
    {
        public static void exec()
        {
            Random random = new Random();
            int[,] matriz = new int[4, 4];
            int maior = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                    
                    if (matriz[i, j] > maior) maior = matriz[i, j];
                }
            }

            Console.WriteLine("O maior número matriz é: " + maior);
        }
    }
}
