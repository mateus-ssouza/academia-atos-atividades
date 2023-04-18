using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q17
    {
        public static void exec()
        {
            // 17.Apresentar os quadrados dos números inteiros de 15 a 200.

            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;
                Console.WriteLine($"O quadrado de {i} é {quadrado}");
            }
        }
    }
}
