using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q18
    {
        public static void exec()
        {
            /* 18. Elaborar um programa que apresente o valor de uma 
             * potência de uma base qualquer elevada a um expoente qualquer, ou seja, NM. 
             */
            Console.Write("Digite a base: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int m = int.Parse(Console.ReadLine());
            
            int resultado = 1;

            for (int i = 0; i < m; i++) resultado *= n;

            Console.WriteLine($"O resultado da potência é: {resultado}");
        }
    }
}