using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 5 - Escreva um algoritmo que leia um vetor de 80 elementos inteiros.
    // Encontre e mostre o menor elemento e a sua posição.

    internal class Q05
    {
        public static void exec()
        {
            int[] vetor = new int[80];
            int menor = int.MaxValue, indice = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    indice = i;
                }
            }

            Console.WriteLine($"O menor valor é {menor} e está no indice {indice}");
        }
    }
}
