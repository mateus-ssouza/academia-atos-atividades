using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 13 - Escreva um algoritmo para ler um vetor de inteiros e positivos e
    // imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá
    // no máximo 100 posições. Sair do programa quando for digitado -1
    // ou quando atingir o máximo de posições do vetor.

    internal class Q13
    {
        public static void exec()
        {
            int[] vetor = new int[100];
            int aux = 0, contador2 = 0, contador4 = 0, contador8 = 0;

            while (aux < 100)
            {
                Console.Write("Digite um número (ou -1 para sair): ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1) break;

                vetor[aux] = numero;
                aux++;
            }

            for (int i = 0; i < aux; i++)
            {
                if (vetor[i] == 2) contador2++;
                else if (vetor[i] == 4) contador4++;
                else if (vetor[i] == 8) contador8++;
            }

            Console.WriteLine($"Número 2 apareceu {contador2} vezes.");
            Console.WriteLine($"Número 4 apareceu {contador4} vezes.");
            Console.WriteLine($"Número 8 apareceu {contador8} vezes.");
        }
    }
}
