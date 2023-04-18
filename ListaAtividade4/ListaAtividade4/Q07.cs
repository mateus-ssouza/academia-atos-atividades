using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 7 - Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor
    // e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
    // lê: 		    |7|40|3|9|21|0|63|31|7|22|
    // escreve: 	|40|0|22|7|3|9|21|63|31|7|

    internal class Q07
    {
        public static void exec()
        {
            int[] vetor = new int[10];
            int[] resultado = new int[10];
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    resultado[aux] = vetor[i];
                    aux++;
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    resultado[aux] = vetor[i];
                    aux++;
                }
            }

            Console.WriteLine("Vetor: [{0}]", string.Join(", ", vetor));
            Console.WriteLine("Resultado: [{0}]", string.Join(", ", resultado));

        }
    }
}
