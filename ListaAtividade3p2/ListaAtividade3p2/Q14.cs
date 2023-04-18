using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q14
    {
        public static void exec()
        {
            // 14. Mostrar as potências de 2 variando de 0 a 10.

            int res = 1;

            for (int i = 0; i <= 10; i++)
            {
                if (i == 0) Console.WriteLine("2 elevado a 0 = 1");
                else
                {
                    for (int j = 0; j < i; j++) res *= 2;

                    Console.WriteLine($"2 elevado a {i} = {res}");
                    res = 1;
                }
            }
        }
    }
}
