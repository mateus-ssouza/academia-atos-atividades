using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 14) Escreva um programa que leia uma matriz de ordem 5 e
    // verifique se os elementos da diagonal principal
    // (da esquerda para a direita) são os mesmos da diagonal
    // secundária(direita pra esquerda).

    internal class Q14
    {
        public static void exec()
        {
            int[,] matriz = new int[5, 5];
            
            bool diagonaisIguais = true;

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
                if (matriz[i, i] != matriz[i, (linha - 1) - i])
                {
                    diagonaisIguais = false;
                    break;
                }
            }

            Console.WriteLine();
            if (diagonaisIguais) Console.WriteLine("Os elementos das diagonais principais e secundárias são iguais.");
            else Console.WriteLine("Os elementos das diagonais principais e secundárias são diferentes.");
        }
    }

}