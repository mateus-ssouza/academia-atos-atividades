using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q16
    {
        public static void exec()
        {
            /* 16. Ler um número N qualquer menor ou igual a 50 e apresentar o 
             * valor obtido da multiplicação sucessiva de N por 3 enquanto o 
             * produto for menor que 250 (N*3; N*3*3; N*3*3*3; etc).
             */
            int n;

            do
            {
                Console.WriteLine("Digite um número (menor ou igual a 50): ");
                n = int.Parse(Console.ReadLine());

                if(n > 50) Console.WriteLine("Número inválido, digite novamente.");

            } while (n > 50);

            int produto = n * 3;

            while (produto < 250)
            {  
                Console.Write($"{produto} ");
                produto *= 3;
            }
        }
    }
}
