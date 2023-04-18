using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas
    // e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o
    // maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrado.

    internal class Q17
    {
        public static void exec()
        {
            int[,] matriz = new int[3, 3];

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);
            int maior = int.MinValue;
            int linhaM = 0, colunaM = 0;

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linhaM = i;
                    }
                }
            }

            int minimax = maior;

            for (int i = 0; i < coluna; i++)
            {
                if (minimax > matriz[linhaM, i])
                {
                    minimax = matriz[linhaM, i];
                    colunaM = i;
                }
            }

            Console.WriteLine("\nO minimax: " + minimax);
            Console.WriteLine($"Foi encontrado na linha {linhaM} e coluna {colunaM}");
        }
    }
}
