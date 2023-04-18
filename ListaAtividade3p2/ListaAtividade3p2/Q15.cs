using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q15
    {
        public static void exec()
        {
            /* 15. Ler 4 valores referentes a notas escolares de um aluno 
             * e imprimir uma mensagem dizendo se ele está aprovado ou reprovado, 
             * após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, 
             * respectivamente. Considerar nota 7,0 como mínima para aprovação.
             */

            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

            if (media >= 7.0) Console.WriteLine($"O aluno está APROVADO com média {media:N2}.");
            else Console.WriteLine($"O aluno está REPROVADO com média {media:N2}.");
        }
    }
}
