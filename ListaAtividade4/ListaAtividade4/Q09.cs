using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 9 - Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
    // e em seguida ordene em ordem crescente os valores desse vetor,
    // utilizando um vetor auxiliar.

    internal class Q09
    {
        public static void exec()
        {
            int[] vetor = new int[10];
            int[] aux = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                int indiceMenor = i;
                for (int j = i + 1; j < 10; j++)
                {
                    if (vetor[j] < vetor[indiceMenor])
                    {
                        indiceMenor = j;
                    }
                }
                aux[i] = vetor[indiceMenor];
                vetor[indiceMenor] = vetor[i];
            }

            Console.WriteLine("Vetor: [{0}]", string.Join(", ", vetor));
            Console.WriteLine("Vetor ordenado: [{0}]", string.Join(", ", aux));
        }
    }
}
