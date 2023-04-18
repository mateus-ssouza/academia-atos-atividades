using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    /* 2 - Escreva um algoritmo que leia valores para dois vetores de 20 elementos e 
     * então realize a soma dos elementos da mesma posição, armazenando o resultado 
     * em um outro vetor.
     */

    internal class Q02
    {
        public static void exec()
        {
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] vetorResultado = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor do vetor1: ");
                vetor1[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite o {i + 1}º valor do vetor2: ");
                vetor2[i] = int.Parse(Console.ReadLine());

                vetorResultado[i] = vetor1[i] + vetor2[i];
            }

            for (int i = 0; i < vetorResultado.Length; i++)
            {
                Console.WriteLine($"\nVetor resultado no indice {i}: {vetorResultado[i]}");
            }
        }
    }
}
