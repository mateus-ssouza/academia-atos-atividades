using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    /* 1 - Escreva um algoritmo que leia os valores para um vetor de 10 elementos 
     * e então mostre na tela a quantidade de números pares e ímpares.
     */

    internal class Q01
    {
        public static void exec()
        {
            int[] vetor = new int[10];
            int contPar = 0, contImpar = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0) contPar++;
                else contImpar++;
            }
            Console.WriteLine($"Total números pares: {contPar}");
            Console.WriteLine($"Total números ímpares: {contImpar}");
        }
    }
}
