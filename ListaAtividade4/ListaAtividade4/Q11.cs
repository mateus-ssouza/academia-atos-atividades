using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 11 - Escreva um programa que leia valores em um vetor de 5 posições.
    // Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

    internal class Q11
    {
        public static void exec()
        {
            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Vetor: ");
            for (int i = 0;i < vetor.Length;i++) Console.Write($"{vetor[i]} ");
            Console.Write("\nVetor inverso: ");
            for (int i = vetor.Length - 1; i >= 0; i--) Console.Write($"{vetor[i]} ");
        }
    }
}
