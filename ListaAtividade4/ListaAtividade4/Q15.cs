using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 15 - Faça um programa em C que declare um vetor de 20 elementos inteiros,
    // leia os conteúdos do vetor, e copie estes conteúdos para outro vetor,
    // invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor
    // deve ser o valor do último elemento do segundo vetor, por exemplo.
    // Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

    internal class Q15
    {
        public static void exec()
        {
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
                vetor2[19 - i] = vetor1[i];
            }

            Console.WriteLine("Vetor 1: [{0}]", string.Join(", ", vetor1));
            Console.WriteLine("Vetor 2: [{0}]", string.Join(", ", vetor2));
        }
    }
}
