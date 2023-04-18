using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.
    // Crie um segundo vetor, substituindo os valores nulos por 2.
    // Mostre os vetores lidos e o vetor resultado.

    internal class Q10
    {
        public static void exec()
        {
            int[] vetor = new int[20];
            int[] resultado = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o valor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] == 0) resultado[i] = 2;
                else resultado[i] = vetor[i];
            }

            Console.WriteLine("Vetor: [{0}]", string.Join(", ", vetor));
            Console.WriteLine("Vetor resultado: [{0}]", string.Join(", ", resultado));
        }
    }
}
