using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q19
    {
        public static void exec()
        {
            /* 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
             * coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
             * 
             * a) média do salário da população;
             * b) média do número de filhos;
             * c) maior salário;
             * d) percentual de pessoas com salário até R$ 100,00.
             * O final da leitura de dados se dará com a entrada de um salário negativo.
             */

            double salario, somaSalario = 0, maiorSalario = 0;
            int numFilhos, somaFilhos = 0, totalPessoas = 0, totalSalarioAte100 = 0;

            Console.WriteLine("Digite o salário (digite um número negativo para encerrar):");
            salario = double.Parse(Console.ReadLine());

            while (salario >= 0)
            {
                Console.WriteLine("Digite o número de filhos:");
                numFilhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaFilhos += numFilhos;
                totalPessoas++;

                if (salario > maiorSalario) maiorSalario = salario;

                if (salario <= 100) totalSalarioAte100++;

                Console.WriteLine("Digite o salário (digite um número negativo para encerrar):");
                salario = double.Parse(Console.ReadLine());
            }

            double mediaSalario = somaSalario / totalPessoas;
            double mediaFilhos = (double)somaFilhos / totalPessoas;
            double percentualSalarioAte100 = ((double)totalSalarioAte100 / totalPessoas) * 100;

            Console.WriteLine($"Média do salário da população: {mediaSalario:N2}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:N2}");
            Console.WriteLine($"Maior salário: {maiorSalario:N2}");
            Console.WriteLine($"Percentual de pessoas com salário até R$ 100,00: {percentualSalarioAte100:N2}%");
        }
    }
}
