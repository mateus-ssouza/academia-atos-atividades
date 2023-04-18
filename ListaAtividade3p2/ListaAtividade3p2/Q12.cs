using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q12
    {
        public static void exec()
        {
            // 12. Apresentar o total da soma dos cem primeiros números inteiros.

            int soma = 0;

            for (int i = 1; i <= 100; i++) soma += i;

            Console.WriteLine("A soma dos cem primeiros números inteiros é: " + soma);
        }
    }
}
