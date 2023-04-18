using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    // 12 - Faça um algoritmo que leia um vetor V de 10 posições e, após,
    // verifica se um número N, fornecido pelo usuário, existe no vetor.
    // Se existir, indicar a(s) posição(ões), senão escrever a mensagem
    // "O número fornecido não existe no vetor!".

    internal class Q12
    {
        public static void exec()
        {
            int[] v = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite um número: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite o número a ser pesquisado: ");
            int n = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < 10; i++)
            {
                if (v[i] == n)
                {
                    Console.WriteLine($"O número {n} foi encontrado na posição {i}.");
                    encontrado = true;
                }
            }
            if (!encontrado) Console.WriteLine("O número fornecido não existe no vetor!");
        }
    }
}
