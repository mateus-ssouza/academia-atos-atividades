using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade4
{
    internal class Q10
    {
        public static void exec()
        {
            /* 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
             * Número de pessoas do sexo masculino.
             * Número de pessoas do sexo feminino.
             * Número de pessoas com idade inferior a 30 anos.
             * Número de pessoas com idade superior a 60 anos.
             * Média de idade das mulheres.
            */

            int numHomens = 0;
            int numMulheres = 0;
            int numMenores30 = 0;
            int numMaiores60 = 0;
            int somaIdadeMulheres = 0;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Dados da pessoa {i}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Sexo (M/F): ");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M') numHomens++;
                else if (sexo == 'F')
                {
                    numMulheres++;
                    somaIdadeMulheres += idade;
                }

                if (idade < 30) numMenores30++;
                else if (idade > 60) numMaiores60++;

            }

            Console.WriteLine($"\nNúmero de pessoas do sexo masculino: {numHomens}");
            Console.WriteLine($"Número de pessoas do sexo feminino: {numMulheres}");
            Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {numMenores30}");
            Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {numMaiores60}");

            if (numMulheres > 0)
            {
                double mediaIdadeMulheres = somaIdadeMulheres / numMulheres;
                Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:F2}");
            }
            else Console.WriteLine("Não foi possível calcular a média de idade das mulheres, pois não há mulheres na lista.");
        }
    }
}
