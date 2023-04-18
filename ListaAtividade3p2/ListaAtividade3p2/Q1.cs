using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q1
    {
        /* 1. Faça um programa em VS que solicite um número inteiro 
         * positivo ao usuário, validando a entrada de dados 
         * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
         * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
         */
        public static void exec()
        {
            int num;

            for (; ; )
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num < 1)
                {
                    Console.WriteLine("\nValor incorreto!\n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Numero digitado: {num}");
                    Console.Write($"Números inteiros pares entre 1 e {num}: ");
                    for (int i = 1; i < num; i++)
                    {
                        if (i % 2 == 0) Console.Write($"{i} ");
                    }
                    break;
                }
            }
        }

        public static void exec2() {
            
            bool outro = true;

            while (outro)
            {
                int x = 0;

                while (x <= 0)
                {
                    Console.Write("Informe um valor positivo: ");
                    x = int.Parse(Console.ReadLine());
                }

                int soma = 0;
                int contagem = 0;

                for (int i = 1; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                        contagem++;
                        soma += i;
                    }
                }

                Console.WriteLine("Deseja informar outr número s/n");
                string resposta = Console.ReadLine();

                if (resposta == "s") outro = true;
                else outro = false;
            }
        }
    }
}
