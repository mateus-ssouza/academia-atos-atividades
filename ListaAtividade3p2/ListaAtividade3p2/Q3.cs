using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q3
    {
        /* 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
         * Se o usuário digitar 0 o programa em VS deve parar. Caso contrário, o 
         * programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.  */

        public static void exec()
        {
            int num, contPrimo = 0;

            for (; ; )
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                else
                {
                    if (num % 2 == 0) Console.WriteLine(num + " é par!");
                    else Console.WriteLine(num + " é ímpar!");

                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0) contPrimo++;
                        if (contPrimo > 2) break;
                    }
                    
                    if (contPrimo == 2) Console.WriteLine(num + " é número primo!");
                    else Console.WriteLine(num + " não é número primo!");
                    contPrimo = 0;
                } 
            }
        }

        public static void exec2()
        {
            int num, contPrimo = 0;

            while (true)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                else
                {
                    if (num % 2 == 0) Console.WriteLine(num + " é par!");
                    else Console.WriteLine(num + " é ímpar!");

                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0) contPrimo++;
                        if (contPrimo > 2) break;
                    }

                    if (contPrimo == 2) Console.WriteLine(num + " é número primo!");
                    else Console.WriteLine(num + " não é número primo!");
                    contPrimo = 0;
                }
            }
        }
    }
}
