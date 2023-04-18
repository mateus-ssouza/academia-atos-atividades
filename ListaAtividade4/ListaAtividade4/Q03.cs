using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 3 - Escreva um algoritmo que leia os valores para um vetor de 20 elementos
    // e então mostre na tela o índice da posição dos valores correspondentes a números primos.

    internal class Q03
    {
        public static void exec()
        {
            int[] vetor = new int[20];
            

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0;i < vetor.Length;i++)
            {
                int contDivisores = 0;

                for (int j = 1; j <= vetor[i]; j++)
                {
                    if (vetor[i] % j == 0) contDivisores++;
                    if (contDivisores > 2) break;
                }

                if (contDivisores == 2) Console.WriteLine($"No indice {i} o número é primo!");
            }
        }
    }
}
