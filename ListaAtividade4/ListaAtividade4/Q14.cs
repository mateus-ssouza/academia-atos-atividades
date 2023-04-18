using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 14 - Escreva um algoritmo que leia um código numérico inteiro
    // e um vetor de 50 posições de números. Se o código for zero,
    // termine o algoritmo. Se o código for 1, mostre o vetor na ordem
    // em que foi lido. Se o código for 2, mostre o vetor na ordem inversa,
    // do último elemento até o primeiro.

    internal class Q14
    {
        public static void exec()
        {
            int codigo, i;
            int[] vetor = new int[50];

            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite um valor[{i}]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("\n\n************** MENU **************");
                Console.WriteLine("1 - Imprimir na ordem original");
                Console.WriteLine("2 - Imprimir na ordem inversa");
                Console.WriteLine("0 - Sair");
                
                Console.Write("\nDigite sua opção: ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    Console.Write("\nVetor na ordem original: ");
                    
                    for (i = 0; i < vetor.Length; i++) Console.Write("{0} ", vetor[i]);

                }
                else if (codigo == 2)
                {
                    Console.Write("\nVetor na ordem inversa: ");

                    for (i = vetor.Length - 1; i >= 0; i--) Console.Write("{0} ", vetor[i]);
                }
            } while (codigo != 0);
        }
    }
}
