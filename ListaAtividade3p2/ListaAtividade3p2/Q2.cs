using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q2
    {
        /* 2. Modificar o programa em VS anterior para que ao final ele 
         * pergunte ao usuário se ele deseja informar um outro número. 
         * Caso positivo, o programa em VS deve ser repetido.
         */
        
        public static void exec()
        {
            int num;
            char flag;

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
                }

                Console.Write("\nDeseja informar outro número (s/n) ? ");
                flag = char.Parse(Console.ReadLine());

                if (flag == 's') continue;
                else break;
            }
        }

        public static void exec2()
        {
            while (true)
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

                Console.WriteLine("Deseja informar outr número s/n: ");
                string resposta = Console.ReadLine();

                if (resposta == "n") break;
            }
        }
    }
}
