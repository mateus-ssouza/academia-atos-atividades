using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 4 - Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação
    // dos elementos de mesmo índice, colocando o resultado em um terceiro vetor.
    // Mostre o vetor resultante.

    internal class Q04
    {
        public static void exec()
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetorResultado = new int[10];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor do vetor1: ");
                vetor1[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite o {i + 1}º valor do vetor2: ");
                vetor2[i] = int.Parse(Console.ReadLine());

                vetorResultado[i] = vetor1[i] * vetor2[i];
            }

            Console.WriteLine("Vetor resultado no: [{0}]", string.Join(", ", vetorResultado));
        }
    }
}
