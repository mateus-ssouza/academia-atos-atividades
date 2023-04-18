using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade5
{
    // 2) Solicite ao usuário, preencher uma Matriz 3x3
    // Informe ao usuário:
    // * A soma dos elementos de cada linha
    // -Ex: Linha 1: 30
    //      Linha 2: 17
    // * A soma dos elementos de cada coluna
    // -Ex: Coluna 1: 23
    //      Coluna 2: 36

    internal class Q02
    {
        public static void exec()
        {
            int[,] matriz = new int[3, 3];
            int somaLinha1 = 0, somaLinha2 = 0, somaLinha3 = 0;
            int somaColuna1 = 0, somaColuna2 = 0, somaColuna3 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor [{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                somaLinha1 += matriz[0, i];
                somaLinha2 += matriz[1, i];
                somaLinha3 += matriz[2, i];
                somaColuna1 += matriz[i, 0];
                somaColuna2 += matriz[i, 1];
                somaColuna3 += matriz[i, 2];
            }

            Console.WriteLine($"Soma linha 1: {somaLinha1}");
            Console.WriteLine($"Soma linha 2: {somaLinha2}");
            Console.WriteLine($"Soma linha 3: {somaLinha3}");
            Console.WriteLine($"Soma coluna 1: {somaColuna1}");
            Console.WriteLine($"Soma coluna 2: {somaColuna2}");
            Console.WriteLine($"Soma coluna 3: {somaColuna3}");
        }
    }
}
