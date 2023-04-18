using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q8
    {
        public static void exec()
        {
            /* 8. Faça um programa em VS que solicite um numero inteiro. 
             * Se o numero não for inteiro, solicite-o até que seja. após, 
             * informe se ele é par ou impar. Finalmente, pergunte ao usuário 
             * se ele quer repetir o programa em VS.
             */

            string entrada;
            int numero;

            while (true)
            {
                Console.WriteLine("Digite um número inteiro: ");
                entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Valor inválido! Digite um número inteiro: ");
                    entrada = Console.ReadLine();
                }

                if (numero % 2 == 0) Console.WriteLine($"O número {numero} é par.");
                else Console.WriteLine($"O número {numero} é ímpar.");

                Console.WriteLine("Deseja executar o programa novamente? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() == "n") break;
            }
        }
    }
}
