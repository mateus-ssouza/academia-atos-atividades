using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q9
    {
        public static void exec()
        {
            /* 9. Faça um programa em VS para Ler a quantidade de filhos de cada 
             * uma das 30 pessoas que visitaram o zoológico num determinado dia, imprimindo:
             * Quantas pessoas tem entre 1 e 3 filhos.
             * Quantas pessoas tem entre 4 e 7 filhos.
             * Quantas pessoas tem mais de 8 filhos.
             * Quantas pessoas não tem filhos.
             */

            int qtdFilhos;
            int qtdPessoasEntre1e3 = 0, qtdPessoasEntre4e7 = 0, qtdPessoasMaisDe8 = 0, qtdPessoasSemFilhos = 0;

            for (int i = 0; i < 30; i++)
            {
                Console.Write($"Digite a quantidade de filhos da pessoa {i + 1}: ");
                qtdFilhos = int.Parse(Console.ReadLine());

                if (qtdFilhos >= 1 && qtdFilhos <= 3) qtdPessoasEntre1e3++;
                else if (qtdFilhos >= 4 && qtdFilhos <= 7) qtdPessoasEntre4e7++;
                else if (qtdFilhos >= 8) qtdPessoasMaisDe8++;
                else qtdPessoasSemFilhos++;

            }

            Console.WriteLine($"\nQuantidade de pessoas com 1 a 3 filhos: {qtdPessoasEntre1e3}");
            Console.WriteLine($"Quantidade de pessoas com 4 a 7 filhos: {qtdPessoasEntre4e7}");
            Console.WriteLine($"Quantidade de pessoas com mais de 8 filhos: {qtdPessoasMaisDe8}");
            Console.WriteLine($"Quantidade de pessoas sem filhos: {qtdPessoasSemFilhos}");
        }
    }
}
