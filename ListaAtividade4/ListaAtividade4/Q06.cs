using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 6 - Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
    // lê: 		    |7|40|3|9|21|0|63|31|7|22|
    // escreve: 	|22|7|31|63|0|21|9|3|40|7|

    internal class Q06
    {
        public static void exec()
        {
            int[] vetor = new int[10];

            for (int i = vetor.Length - 1; i >= 0 ; i--)
            {
                Console.Write($"Digite o {10 - i}º valor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor: [{0}]", string.Join(", ", vetor));
        }
    }
}
